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
    public partial class AccountantsForm : Form
    {
        public AccountantsForm()
        {
            InitializeComponent();
        }
        int _id
        {
            get
            {
                string query = $"select id_pracyvnika from users where login='{Program.loginForm.LoginString}'and password='{Program.loginForm.PasswordString}'";
                using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
                {
                    SqlCommand comm = new SqlCommand(query, defconn);
                    defconn.Open();
                    return (int)comm.ExecuteScalar();
                }
            }
        }
        SqlDataAdapter ordersDataAdapter;
        string CommText { get { return String.Format("select order_view.id_zamovnyka as Замовник,PIB.PIB as Менеджер,order_view.data_zamovy as Дата,order_view.cost as Вартість from order_view inner join PIB on order_view.id_menegera=PIB.id {0}", GetOrderConditions()); } }
        SqlCommand SortCommand = new SqlCommand();
        private void AccountantsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.syrovina". При необходимости она может быть перемещена или удалена.
            this.syrovinaTableAdapter.Fill(this.factoryDataSet.syrovina);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zakupivli". При необходимости она может быть перемещена или удалена.
            this.zakupivliTableAdapter.Fill(this.factoryDataSet.zakupivli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.factoryDataSet.zarplata);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zamova". При необходимости она может быть перемещена или удалена.
            this.zamovaTableAdapter.Fill(this.factoryDataSet.zamova);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zamovnyk". При необходимости она может быть перемещена или удалена.
            this.zamovnykTableAdapter.Fill(this.factoryDataSet.zamovnyk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.purchase_view". При необходимости она может быть перемещена или удалена.
            this.purchase_viewTableAdapter.Fill(this.factoryDataSet.purchase_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.order_view". При необходимости она может быть перемещена или удалена.
            this.order_viewTableAdapter.Fill(this.factoryDataSet.order_view);
            // TODO: данная строка кода позвоthis.factoryDataSet.order_view)ляет загрузить данные в таблицу "factoryDataSet.salary". При необходимости она может быть перемещена или удалена.
            this.salaryTableAdapter.Fill(this.factoryDataSet.salary);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet1.PIB". При необходимости она может быть перемещена или удалена.
            this.pIBTableAdapter.Fill(this.factoryDataSet1.PIB);
            this.zarplataTableAdapter.Fill(this.factoryDataSet.zarplata);
            DataTable dataTable = new DataTable();
            managerLabel.Text = pIBTableAdapter.GetName(Program.loginForm.User_id);
            this.menegeryTableAdapter.Adapter.SelectCommand = new SqlCommand("select PIB.id,PIB.PIB from PIB inner join menegery on PIB.id=menegery.id_pracivnyka;", new SqlConnection(Properties.Settings.Default.DefaultConnection));
            this.menegeryTableAdapter.Adapter.Fill(dataTable);
            managerComboBox.DataSource = dataTable;
            managerComboBox.DisplayMember = "PIB";
            managerComboBox.ValueMember = "id";
        }
        private void Sort(object sender,EventArgs e)
        {
            SqlCommand SortCommand = new SqlCommand(CommText);
            SortCommand.Connection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            SortCommand.Connection.Open();
            DataTable dataTable = new DataTable();
            this.ordersDataAdapter = new SqlDataAdapter(SortCommand);
            this.ordersDataAdapter.Fill(dataTable);
            PurchaseFinanceView.DataSource = dataTable;
        }
        private string GetOrderConditions()
        {
            string res="";
            if (dateCheckBox.Checked | customerCheckBox.Checked | managerCheckBox.Checked)
            {
                res += "where ";
            }
            if (dateCheckBox.Checked) 
            {
                res += String.Format("data_zamovy between '{0}' and '{1}' ", dateTimePickerStart.Text, dateTimePickerEnd.Text);
                if (customerCheckBox.Checked | managerCheckBox.Checked) res += "and ";
            
            }
            if (customerCheckBox.Checked)
            {
                res += String.Format("id_zamovnyka={0} ", customerComboBox.Text);
                if (managerCheckBox.Checked) res += "and ";
            }
            if (managerCheckBox.Checked)
            {
                res += String.Format("id_menegera={0}", managerComboBox.SelectedValue);
            }
            res += ";";
            return res;
        }
        private void salaryWorkerComboBox_TextUpdate(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(salaryWorkerComboBox.SelectedValue);
            string query = String.Format("select tip_platy from posada join pracivnyki on posada.nazva=pracivnyki.posada where pracivnyki.id={0}", id);
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
            {
                SqlCommand comm = new SqlCommand(query, defconn);
                defconn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                string _type = " ";
                try
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        _type = reader.GetString(0);
                    }
                    else throw new Exception("Такого працівника не існує");
                }
                finally
                {
                    if (_type == "Погодинна оплата")
                    {
                        hoursPanel.Visible = true;
                        hoursPanel.Enabled = true;
                    }
                }
            }
        }
        private void addSalaryButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(salaryWorkerComboBox.SelectedValue);
            string date = salaryDateTimePicker.Value.ToString("yyyy-MM-dd");
            int hours = 0; 
            string query;
            if (HoursBox.Visible)
            {
                hours = (int)HoursBox.Value;
                query = String.Format("insert into zarplata(id_pracivnyka,data_vydachi,hodyn_praci) " +
                    "values({0},'{1}',{2})", id, date, hours);
            }
            else query = String.Format("insert into zarplata(id_pracivnyka,data_vydachi) " +
                    "values({0},'{1}')", id, date);
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
            {
                SqlCommand comm = new SqlCommand(query, defconn);
                defconn.Open();
                try
                {
                    comm.ExecuteNonQuery();
                }
                finally
                {
                    HoursBox.Value = 0;
                    hoursPanel.Visible = false;
                    hoursPanel.Enabled = false;
                    this.salaryTableAdapter.Fill(this.factoryDataSet.salary);
                }
            }
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            PurchaseViewPanel.Visible = false;
            pictureBox1.Visible = false;
            OrdersViewPanel.Visible = false;
            WorkerListPanel.Visible = true;
        }

        private void FinancialViewButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            PurchaseViewPanel.Visible = false;
            WorkerListPanel.Visible = false;
            OrdersViewPanel.Visible = true;
        }

        private void FinancialReportButton_Click(object sender, EventArgs e)
        {
            PrintFinancialReportForm form = new PrintFinancialReportForm(); 
            form.Show();
            pictureBox1.Visible = true;
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.Enabled = dateCheckBox.Checked; 
            dateTimePickerEnd.Enabled = dateCheckBox.Checked; 
            Sort(sender,e);
        }

        private void customerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            customerComboBox.Enabled = customerCheckBox.Checked; 
            Sort(sender,e);
        }

        private void managerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            managerComboBox.Enabled = managerCheckBox.Checked; 
            Sort(sender, e);
        }

        private void AccountantsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Show();
        }
        private void deleteSalaryButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DefaultConnection); 
            int id;
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select id from PIB where PIB=N'{0}';", SalaryView.SelectedCells[0].OwningRow.Cells[0].Value),sqlConnection);
                DateTime date = (DateTime)SalaryView.SelectedCells[0].OwningRow.Cells[2].Value;
                id = (int)sqlCommand.ExecuteScalar();
                sqlCommand.CommandText = String.Format("delete from zarplata where id_pracivnyka={0} and data_vydachi='{1}';", id, date.ToString("yyyy-MM-dd")) ;
                sqlCommand.ExecuteNonQuery();
            }
            this.zarplataTableAdapter.Update(this.factoryDataSet.zarplata);
            SalaryView.Rows.Remove(SalaryView.SelectedCells[0].OwningRow); 
            this.salaryTableAdapter.Fill(this.factoryDataSet.salary);
        }
        private void updateSalaryButton_Click(object sender, EventArgs e)
        {
            if (SalaryView.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                deleteSalaryButton.Enabled = false;
                addSalaryButton.Enabled = false;
                SalaryView.EditMode = DataGridViewEditMode.EditOnKeystroke;
                salaryDateTimePicker.Value= (DateTime)SalaryView.SelectedCells[0].OwningRow.Cells[2].Value;
                dateSalaryCheckBox.Checked = true;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select id from PIB where PIB=N'{0}';", SalaryView.SelectedCells[0].OwningRow.Cells[0].Value), sqlConnection);
                salaryWorkerComboBox.SelectedValue=sqlCommand.ExecuteScalar();
            }
            else
            {
                deleteSalaryButton.Enabled = true;
                addSalaryButton.Enabled = true;
                SalaryView.EditMode = DataGridViewEditMode.EditProgrammatically;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
                int id;
                int _id = (int)salaryWorkerComboBox.SelectedValue;
                DateTime _date = salaryDateTimePicker.Value;
                int _hours = (int)HoursBox.Value;
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(String.Format("select id from PIB where PIB=N'{0}';", SalaryView.SelectedCells[0].OwningRow.Cells[0].Value), sqlConnection);
                    DateTime date = (DateTime)SalaryView.SelectedCells[0].OwningRow.Cells[2].Value;
                    id = (int)sqlCommand.ExecuteScalar();
                    string hours = (HoursBox.Enabled) ? ", hours=" + _hours : "";
                    sqlCommand.CommandText = $"update zarplata set id_pracivnyka={_id}, data_vydachi='{_date.ToString("yyyy-MM-dd")}'{hours} where id_pracivnyka={id} and data_vydachi='{date.ToString("yyyy-MM-dd")}';";
                    sqlCommand.ExecuteNonQuery();
                }
                this.zarplataTableAdapter.Update(this.factoryDataSet.zarplata);
                SalaryView.Rows.Remove(SalaryView.SelectedCells[0].OwningRow);
                this.salaryTableAdapter.Fill(this.factoryDataSet.salary);
            }
        }

        private void dateSalaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            salaryDateTimePicker.Enabled=dateSalaryCheckBox.Checked;
            if (!salaryDateTimePicker.Enabled) salaryDateTimePicker.Value = DateTime.Now;
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            OrdersViewPanel.Visible = false;
            WorkerListPanel.Visible = false;
            PurchaseViewPanel.Visible = true;
        }

        private void purchaseAddButton_Click(object sender, EventArgs e)
        {
            string name= (string)materialСomboBox.Text;
            string date = purchaseDateTimePicker.Value.ToString("yyyy-MM-dd");
            int count = (int)purchaseCount.Value;
            string query = String.Format("insert into zakupivli(nazva_syroviny,data_zakupivli,kilkist) " +
                    "values(N'{0}','{1}',{2})", name, date, count);
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
            {
                SqlCommand comm = new SqlCommand(query, defconn);
                defconn.Open();
                try
                {
                    comm.ExecuteNonQuery();
                }
                finally
                {
                    this.purchase_viewTableAdapter.Fill(this.factoryDataSet.purchase_view);
                }
            }
        }

        private void purchaseDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            purchaseDateTimePicker.Enabled = purchaseDateCheckBox.Checked;
            if (!purchaseDateTimePicker.Enabled) purchaseDateTimePicker.Value = DateTime.Now;
        }
        private void materialСomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            materialCurrentCount.Text = $"{materialСomboBox.SelectedValue}";
        }
    }
}