using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class ManagerForm : Form
    {
        int order_id = 0;
        DataTable dataTable = new DataTable();
        List<int> instances_id = new List<int>();
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Show();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            NewOrder.Visible = true;
            OwnOrders.Visible = false;
            CustomerListPanel.Visible = false;
            NewOrderButton.Enabled = false;
            NewCustomerButton.Enabled = true;
            OwnOrdersButton.Enabled = true;
            this.zamovaTableAdapter.Insert((int)customerComboBox.SelectedValue, Program.loginForm.User_id, dateTimePicker.Value); 
            string query = "select IDENT_CURRENT('zamova')";
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
            {
                defconn.Open();
                SqlCommand comm = new SqlCommand(query, defconn);
                order_id = Convert.ToInt32(comm.ExecuteScalar());
            }
            goodsCheckBox_SelectedIndexChanged(sender, e);
            orderIdLabel.Text = $"Порядковий номер замови: {order_id}";
            dataTable.Clear();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            NewOrder.Visible = false;
            OwnOrders.Visible = false;
            CustomerListPanel.Visible = true;
            NewOrderButton.Enabled = true;
            NewCustomerButton.Enabled = false;
            OwnOrdersButton.Enabled = true;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.PIB". При необходимости она может быть перемещена или удалена.
            this.pIBTableAdapter.Fill(this.factoryDataSet.PIB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.order_view". При необходимости она может быть перемещена или удалена.
            this.order_viewTableAdapter.Fill(this.factoryDataSet.order_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.partia". При необходимости она может быть перемещена или удалена.
            this.partiaTableAdapter.Fill(this.factoryDataSet.partia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zamova". При необходимости она может быть перемещена или удалена.
            this.zamovaTableAdapter.Fill(this.factoryDataSet.zamova);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.factoryDataSet.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zamovnyk". При необходимости она может быть перемещена или удалена.
            this.zamovnykTableAdapter.Fill(this.factoryDataSet.zamovnyk);
            managerLabel.Text = pIBTableAdapter.GetName(Program.loginForm.User_id);
            NewOrder.Visible = false;
            OwnOrders.Visible = false;
            CustomerListPanel.Visible = false;
            dataGridView.AutoGenerateColumns = false;
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("Товар"), new DataColumn("Кількість"), new DataColumn("Вартість") });
            dataGridView.DataSource = dataTable;
        }

        private void goodsCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            instanceCount.Maximum = 0;
            instances_id.Clear();
            SqlConnection defConn = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            string query = $"select id_partii from partia where nazva_tovaru=N'{(string)goodsCheckBox.SelectedValue}' and id_zamovy is null order by data_vygotovlennya desc";
            using (defConn)
            {
                SqlCommand comm = new SqlCommand(query, defConn);
                defConn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    addItemButton.Enabled = true;
                    while (reader.Read())
                    {
                        instances_id.Add(reader.GetInt32(0));
                        instanceCount.Maximum++;
                    }
                }
                else
                {
                    addItemButton.Enabled = false;
                }
            }
        }

        private void addNewOrderButton_Click(object sender, EventArgs e)
        {
            zamovaTableAdapter.UpdateQuery((int)customerComboBox.SelectedValue, Program.loginForm.User_id, dateTimePicker.Value, order_id);
            NewOrderButton.Enabled = true;
            NewCustomerButton.Enabled = true;
            OwnOrdersButton.Enabled = true;
            generalCountLabel.Text = $"Загальна вартість: {order_viewTableAdapter.ScalarQuery(order_id)}";
            NewOrder.Visible =false;
            dataTable.Clear();
            pictureBox1.Visible = true;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            int fl = -1;
            string name = (string)goodsCheckBox.SelectedValue;
            int count = (int)instanceCount.Value;
            decimal price = (decimal)tovarTableAdapter.GetPriceBy((string)goodsCheckBox.SelectedValue);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if ((string)row.Cells[0].Value == name)
                {
                    fl = row.Index; 
                    break;
                }
            }
            try
            {
                if (fl == -1) dataTable.Rows.Add(name, count, (price * count));
                else
                {
                    dataGridView.Rows[fl].Cells[1].Value = (int)dataGridView.Rows[fl].Cells[1].Value + count;
                    dataGridView.Rows[fl].Cells[2].Value = (decimal)dataGridView.Rows[fl].Cells[1].Value * price;
                }
            }
            catch
            {

            }
            for (int i=0;i<instanceCount.Value; i++)
            {
                partiaTableAdapter.UpdateOrderId(order_id, instances_id[i], 1);
            }
            goodsCheckBox_SelectedIndexChanged(sender, e);
            generalCountLabel.Text = $"Загальна вартість: {order_viewTableAdapter.ScalarQuery(order_id)}";
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (string)dataGridView.SelectedCells[0].OwningRow.Cells[0].Value;
                dataGridView.Rows.Remove(dataGridView.SelectedCells[0].OwningRow);
                partiaTableAdapter.ClearByName(name, order_id); 
                addItemButton.Click -= deleteItemButton_Click;
            }
            catch
            {

            }
        }

        private void changeItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (string)dataGridView.SelectedCells[0].OwningRow.Cells[0].Value;
                partiaTableAdapter.ClearByName(name, order_id);
                goodsCheckBox.SelectedValue = name;
                instanceCount.Value= (decimal)dataGridView.SelectedCells[0].OwningRow.Cells[1].Value;
                addItemButton.Click += deleteItemButton_Click;
            }
            catch
            {

            }
        }

        private void OwnOrdersButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            OwnOrders.Visible = true;
            NewOrder.Visible = false;
            CustomerListPanel.Visible = false;
            NewOrderButton.Enabled = true;
            NewCustomerButton.Enabled = true;
            OwnOrdersButton.Enabled = false;
            DataTable ownOrders = new DataTable();
            string query = $"select id_zamovy Номер, id_zamovnyka Замовник, cost Загальна_вартість, data_zamovy as Дата from order_view where id_menegera={Program.loginForm.User_id}";
            SqlCommand comm = new SqlCommand(query);
            comm.Connection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            SqlDataAdapter orderAdapter = new SqlDataAdapter(comm);
            orderAdapter.Fill(ownOrders);
            OrdersView.AutoGenerateColumns = true;
            OrdersView.DataSource = ownOrders;
            percentLabel.Text = "Процентна виплата за часовий проміжок: " + GetPercentByDates(firstDateTimePicker.Value,lastDateTimePicker.Value).ToString("F");
            dataTable.Clear();
        }

        private void changeOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                row = OrdersView.SelectedCells[0].OwningRow;
            }
            catch
            {
                row = OrdersView.SelectedRows[0];
            }
            order_id = (int)row.Cells["Номер"].Value;
            NewOrder.Visible = true;
            OwnOrders.Visible = false;
            NewOrderButton.Enabled = false;
            NewCustomerButton.Enabled = false;
            customerComboBox.SelectedValue = row.Cells["Замовник"].Value;
            dateTimePicker.Value = (DateTime)row.Cells["Дата"].Value;
            goodsCheckBox_SelectedIndexChanged(sender, e);
            orderIdLabel.Text = $"Порядковий номер замови: {order_id}";
            string query = "select partia.nazva_tovaru Товар, count(partia.id_partii) Кількість, count(partia.id_partii)*tovar.cina_partii Вартість from partia inner join tovar " +
                $"on partia.nazva_tovaru=tovar.nazva where partia.id_zamovy={order_id} group by partia.nazva_tovaru, tovar.cina_partii";
            SqlCommand comm = new SqlCommand(query);
            comm.Connection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            SqlDataAdapter orderAdapter = new SqlDataAdapter(comm);
            orderAdapter.Fill(dataTable);
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                order_id = (int)OrdersView.SelectedCells[0].OwningRow.Cells["Номер"].Value;
            }
            catch
            {
                order_id = (int)OrdersView.SelectedRows[0].Cells["Номер"].Value;
            }
            zamovaTableAdapter.DeleteQuery(order_id);
            DataTable ownOrders = new DataTable();
            string query = $"select id_zamovy Номер, id_zamovnyka Замовник, cost Загальна_вартість, data_zamovy as Дата from order_view where id_menegera={Program.loginForm.User_id}";
            SqlCommand comm = new SqlCommand(query);
            comm.Connection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            SqlDataAdapter orderAdapter = new SqlDataAdapter(comm);
            orderAdapter.Fill(ownOrders);
            OrdersView.AutoGenerateColumns = true;
            OrdersView.DataSource = ownOrders;
        }

        private decimal GetPercentByDates(DateTime first, DateTime last)
        {
            string query = $"select posada.procent from posada inner join pracivnyki on pracivnyki.posada=posada.nazva where pracivnyki.id={Program.loginForm.User_id}";
            SqlCommand comm = new SqlCommand(query, new SqlConnection(Properties.Settings.Default.DefaultConnection));
            comm.Connection.Open();
            try
            {
                return (decimal)comm.ExecuteScalar() * (decimal)order_viewTableAdapter.IncomeDateCount(first, last);
            }
            catch
            {
                return 0;
            }
        }

        private void firstDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            percentLabel.Text = $"Процентна виплата за часовий проміжок: {GetPercentByDates(firstDateTimePicker.Value, lastDateTimePicker.Value).ToString("F")}";
        }

        private void lastDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            percentLabel.Text = $"Процентна виплата за часовий проміжок: {GetPercentByDates(firstDateTimePicker.Value, lastDateTimePicker.Value).ToString("F")}";
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                zamovnykTableAdapter.Insert(nameTextBox.Text, phoneTextBox.Text, emailTextBox.Text);
            }
            finally 
            {
                nameTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
            }
            zamovnykTableAdapter.Fill(factoryDataSet.zamovnyk);
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = (int)customerView.SelectedCells[0].OwningRow.Cells[0].Value;
            }
            catch
            {
                id=(int)customerView.SelectedRows[0].Cells[0].Value;
            }
            zamovnykTableAdapter.DeleteQuery(id);
            zamovnykTableAdapter.Fill(factoryDataSet.zamovnyk);
        }

        private DataGridViewRow row;
        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                row = customerView.SelectedCells[0].OwningRow;
            }
            catch
            {
                row = customerView.SelectedRows[0];
            }
            nameTextBox.Text = (string)row.Cells[1].Value;
            phoneTextBox.Text = (string)row.Cells[2].Value;
            emailTextBox.Text = (string)row.Cells[3].Value;
            updateCustomerButton.Click -= updateCustomerButton_Click;
            updateCustomerButton.Click += updateCustomerFinal;
            updateCustomerButton.Text = "Cкінчити редагування";
            addCustomerButton.Enabled = false;
            deleteCustomerButton.Enabled = false;
        }

        private void updateCustomerFinal(object sender,EventArgs e)
        {
            try
            {
                zamovnykTableAdapter.UpdateQuery(nameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, (int)row.Cells[0].Value);
            }
            finally
            {
                nameTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
            }
            updateCustomerButton.Click += updateCustomerButton_Click;
            updateCustomerButton.Click -= updateCustomerFinal;
            updateCustomerButton.Text = "Редагувати";
            addCustomerButton.Enabled = true;
            deleteCustomerButton.Enabled = true;
            zamovnykTableAdapter.Fill(factoryDataSet.zamovnyk);
        }

        private void orferReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                order_id = (int)OrdersView.SelectedCells[0].OwningRow.Cells[0].Value;
            }
            catch
            {
                order_id = (int)OrdersView.SelectedRows[0].Cells[0].Value;
            }
            OrderReportForm form = new OrderReportForm(order_id);
            form.Show();
        }
    }
}