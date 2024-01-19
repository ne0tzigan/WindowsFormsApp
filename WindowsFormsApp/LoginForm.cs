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
    public partial class Login : Form
    {
        public string LoginString;
        public string PasswordString;
        public int User_id
        {
            get
            {
                string query = $"select id_pracyvnika from users where login='{LoginString}'and password='{PasswordString}'";
                using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
                {
                    SqlCommand comm = new SqlCommand(query, defconn);
                    defconn.Open();
                    try
                    {
                        return (int)comm.ExecuteScalar();
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
        }
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
        

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginString = LoginTextBox.Text;
            PasswordString = PasswordTextBox.Text;
            string LoginQuery = "select type from users where login='" + LoginString + "'and password='" + PasswordString + "'";
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection)) 
            {
                SqlCommand comm = new SqlCommand(LoginQuery,defconn);
                defconn.Open();
                string _type=" ";
                try
                {
                    _type = (string)comm.ExecuteScalar();

                }
                finally
                {
                    switch (_type)
                    {
                        case "Manager":
                            ManagerForm managerForm = new ManagerForm();
                            managerForm.Show();
                            Hide();
                            break;
                        case "Accountant":
                            AccountantsForm accountantsForm = new AccountantsForm();
                            accountantsForm.Show();
                            Hide();
                            break;
                        case "HR":
                            HRForm hrForm = new HRForm();
                            hrForm.Show();
                            Hide();
                            break;
                        case "Warehouse_worker":
                            ProductionForm productionForm = new ProductionForm();
                            productionForm.Show();
                            Hide();
                            break;
                        case "Admin":
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            Hide();
                            break;
                        default:
                            MessageBox.Show("Неправильний логін або пароль");
                            break;
                    }
                }            
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}