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
    public partial class ProductionForm : Form
    {
        factoryDataSet.partiaDataTable productsDataTable = new factoryDataSet.partiaDataTable();
        DataTable materialsDataTable = new DataTable();
        string SortCommText { get { return $"select * from partia {GetConditions()}"; } }

        public ProductionForm()
        {
            InitializeComponent();
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.zamova". При необходимости она может быть перемещена или удалена.
            this.zamovaTableAdapter.Fill(this.factoryDataSet.zamova);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.syrovina". При необходимости она может быть перемещена или удалена.
            this.syrovinaTableAdapter.Fill(this.factoryDataSet.syrovina);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.factoryDataSet.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.partia". При необходимости она может быть перемещена или удалена.
            this.partiaTableAdapter.Fill(this.factoryDataSet.partia);
            managerLabel.Text = pIBTableAdapter.GetName(Program.loginForm.User_id);
            ProductsPanel.Visible = false;
            addInstancePanel.Visible = false;
            productionView.DataSource = productsDataTable;
            materialView.DataSource = materialsDataTable;
        }

        private void instanceViewButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ProductsPanel.Visible = true;
            addInstancePanel.Visible = false;
            partiaTableAdapter.FillIfNull(productsDataTable);
            productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = false;
        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ProductsPanel.Visible = false;
            addInstancePanel.Visible = true;
            CountMaterials();
        }

        private void CountMaterials()
        {
            string CountCommText = $"select syrovina.nazva,vygotovlennya.kilkist_syroviny,syrovina.u_nayavnosti from syrovina inner join vygotovlennya on vygotovlennya.nazva_syroviny=syrovina.nazva where vygotovlennya.nazva_tovaru=N'{productComboBox.SelectedValue}'";
            SqlCommand comm = new SqlCommand(CountCommText);
            comm.Connection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            comm.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
            materialsDataTable.Clear();
            dataAdapter.Fill(materialsDataTable);
            int min = Int32.MaxValue;
            foreach (DataRow dataRow in materialsDataTable.Rows)
            {
                if (min > (int)dataRow[2] / (int)dataRow[1]) min = (int)dataRow[2] / (int)dataRow[1];
            }
            instancesNumber.Maximum = min;
        }

        private void Sort(object sender, EventArgs e)
        {
            SqlCommand SortCommand = new SqlCommand(SortCommText);
            SortCommand.Connection = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            SortCommand.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SortCommand);
            productsDataTable.Clear();
            try
            {
                dataAdapter.Fill(productsDataTable);
            }
            catch
            {

            }
        }
        private string GetConditions()
        {
            string res = "";
            if (dateCheckBox.Checked | orderedGoodsCheckBox.Checked | productSortCheckBox.Checked)
            {
                res += "where ";
            }
            if (orderedGoodsCheckBox.Checked)
            {
                res += $"id_zamovy={orderedGoodsComboBox.SelectedValue} ";
                if (dateCheckBox.Checked | productSortCheckBox.Checked) res += "and ";
            }
            if (productSortCheckBox.Checked)
            {
                res += $"nazva_tovaru=N'{productSortComboBox.SelectedValue}' ";
                if (dateCheckBox.Checked) res += "and ";
            }
            if (dateCheckBox.Checked)
            {
                res += String.Format("data_vygotovlennya between '{0}' and '{1}'", dateTimePickerStart.Text, dateTimePickerEnd.Text);
            }
            res += ";";
            return res;
        }

        private void orderedGoodsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            orderedGoodsComboBox.Visible = orderedGoodsCheckBox.Checked;
            if (!dateCheckBox.Checked & !productSortCheckBox.Checked & !orderedGoodsCheckBox.Checked)
            {
                partiaTableAdapter.FillIfNull(productsDataTable);
                productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = false;
            }
            else
            {
                productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = true;
                Sort(sender, e);
            }
        }
        private void productSortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            productSortComboBox.Visible = productSortCheckBox.Checked;
            if (!dateCheckBox.Checked & !productSortCheckBox.Checked & !orderedGoodsCheckBox.Checked)
            {
                partiaTableAdapter.FillIfNull(productsDataTable);
                productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = false;
            }
            else
            {
                productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = true;
                Sort(sender, e);
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.Visible = dateCheckBox.Checked;
            dateTimePickerEnd.Visible = dateCheckBox.Checked;
            label4.Visible = dateCheckBox.Checked;
            if (!dateCheckBox.Checked & !productSortCheckBox.Checked & !orderedGoodsCheckBox.Checked)
            {
                partiaTableAdapter.FillIfNull(productsDataTable);
                productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = false;
            }
            else
            {
                productionView.Columns["idzamovyDataGridViewTextBoxColumn"].Visible = true;
                Sort(sender, e);
            }
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountMaterials();
            instancesNumber.Value = 0;
        }

        private void addInstanceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < instancesNumber.Value; i++)
            {
                partiaTableAdapter.Insert((string)productComboBox.SelectedValue, dateTimePicker.Value, null);
            }
            instancesNumber.Value = 0;
        }
        private void ProductionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.partiaTableAdapter.Fill(this.factoryDataSet.partia);
            this.syrovinaTableAdapter.Fill(this.factoryDataSet.syrovina);
            Program.loginForm.Show();
        }
    }
}