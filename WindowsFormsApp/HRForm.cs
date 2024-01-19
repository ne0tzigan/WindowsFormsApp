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
    public partial class HRForm : Form
    {
        int id;
        public HRForm()
        {
            InitializeComponent();
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.pracivnyki". При необходимости она может быть перемещена или удалена.
            this.pracivnykiTableAdapter.Fill(this.factoryDataSet.pracivnyki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.posada". При необходимости она может быть перемещена или удалена.
            this.posadaTableAdapter.Fill(this.factoryDataSet.posada);
            this.pIBTableAdapter.Fill(this.factoryDataSet.PIB);
            managerLabel.Text = pIBTableAdapter.GetName(Program.loginForm.User_id);

        }

        private void NewWorkerButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            this.WorkerListPanel.Visible = false;
            this.NewWorkerPanel.Visible = true;
        }

        private void WorkerListButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            this.posadaTableAdapter.Fill(this.factoryDataSet.posada);
            this.pracivnykiTableAdapter.Fill(this.factoryDataSet.pracivnyki);
            this.NewWorkerPanel.Visible = false;
            this.WorkerListPanel.Visible = true;
        }

        private void SubmitWorkerButton_Click(object sender, EventArgs e)
        {
            string surname = surnameTextBox.Text.Replace("'", "''"); ;
            string name = nameTextBox.Text.Replace("'","''");
            string patronim = patronimTextBox.Text.Replace("'", "''"); ;
            string phoneNum = phoneNumTextBox.Text;
            DataRowView dataRowView = (DataRowView)posadaBox.SelectedItem;
            string posada = dataRowView.Row.Field<string>("nazva");
            try
            {
                this.pracivnykiTableAdapter.Insert(surname, name, patronim, phoneNum, posada, dateOfBirth.Value);
            }
            finally
            {
                surnameTextBox.Text = "";
                nameTextBox.Text = "";
                patronimTextBox.Text = "";
                phoneNumTextBox.Text = "";
                dateOfBirth.Value = DateTime.Today;
                posadaBox.SelectedIndex = 0;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            WorkersView.Rows.Remove(WorkersView.SelectedCells[0].OwningRow);
            this.pracivnykiTableAdapter.Update(this.factoryDataSet.pracivnyki);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            NewWorkerPanel.Visible = true; 
            WorkerListPanel.Visible = false;
            SubmitWorkerButton.Click -= SubmitWorkerButton_Click;
            SubmitWorkerButton.Click += SubmitWorkerButton_Update;
            SubmitWorkerButton.Text = "Cкінчити редагування";
            DataGridViewRow row = WorkersView.SelectedCells[0].OwningRow;
            id = (int)row.Cells[0].Value;
            surnameTextBox.Text = (string)row.Cells[1].Value;
            nameTextBox.Text = (string)row.Cells[2].Value;
            patronimTextBox.Text = (string)row.Cells[3].Value;
            phoneNumTextBox.Text = (string)row.Cells[4].Value;
            dateOfBirth.Value = (DateTime)row.Cells[6].Value;
            posadaBox.SelectedItem= (string)row.Cells[5].Value;
        }

        private void SubmitWorkerButton_Update(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            NewWorkerPanel.Visible = false; 
            WorkerListPanel.Visible = true;
            SubmitWorkerButton.Click -= SubmitWorkerButton_Update;
            SubmitWorkerButton.Click += SubmitWorkerButton_Click;
            SubmitWorkerButton.Text = "Додати"; 
            string surname = surnameTextBox.Text.Replace("'", "''"); ;
            string name = nameTextBox.Text.Replace("'", "''");
            string patronim = patronimTextBox.Text.Replace("'", "''"); ;
            string phoneNum = phoneNumTextBox.Text;
            DataRowView dataRowView = (DataRowView)posadaBox.SelectedItem;
            string posada = dataRowView.Row.Field<string>("nazva");
            try
            {
                string query = $"update pracivnyki set familia=N'{surname}', imya=N'{name}', pobatkovi=N'{patronim}', tel_nomer='{phoneNum}', posada=N'{posada}', data_narodzhennya='{dateOfBirth.Value}' where id={id}";
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.DefaultConnection);
                conn.Open();
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            finally
            {
                surnameTextBox.Text = "";
                nameTextBox.Text = "";
                patronimTextBox.Text = "";
                phoneNumTextBox.Text = "";
                dateOfBirth.Value = DateTime.Today;
                posadaBox.SelectedIndex = 0;
            }
            pracivnykiTableAdapter.Update(factoryDataSet.pracivnyki);
            pracivnykiTableAdapter.Fill(factoryDataSet.pracivnyki);
        }

        private void HRForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PIBSearch.Visible = checkBox1.Checked;
            if (PIBSearch.Visible)
            {
                factoryDataSet.pracivnyki.Clear();
                pracivnykiTableAdapter.Fill(factoryDataSet.pracivnyki);  
            }
        }

        private void PIBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PIBSearch.Visible)
            {
                try
                {
                    SqlDataAdapter workerAdapter = new SqlDataAdapter($"select * from pracivnyki where id={(int)PIBSearch.SelectedValue}", Properties.Settings.Default.DefaultConnection);
                    factoryDataSet.pracivnyki.Clear();
                    workerAdapter.Fill(factoryDataSet.pracivnyki);
                }
                catch { }
            }
        }
    }
}
