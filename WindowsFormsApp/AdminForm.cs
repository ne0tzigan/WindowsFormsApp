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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        DataTable userTable = new DataTable();
        SqlDataAdapter userAdapter = new SqlDataAdapter("select users.login Логін, users.password Пароль, users.type [Рівень доступа], pracivnyki.id [Номер працівника], PIB.PIB ПІБ, pracivnyki.posada Посада from users " +
            "left join pracivnyki on pracivnyki.id=users.id_pracyvnika " +
            "left join PIB on pracivnyki.id=PIB.id"
            , Properties.Settings.Default.DefaultConnection);
        DataTable productTable = new DataTable();
        SqlDataAdapter productAdapter = new SqlDataAdapter("select " +
            "t.nazva [Назва товару], " +
            "t.kilkist_u_partii [Штук у партії], " +
            "t.cina_partii [Ціна партії]," +
            "count(partia.id_partii) [Продано загалом]," +
            "(select " +
                "count(partia.id_partii) from tovar " +
                "left join partia on partia.nazva_tovaru=tovar.nazva " +
                "inner join zamova on partia.id_zamovy=zamova.id_zamovy " +
                "where (tovar.nazva=t.nazva) and (DATEDIFF(MONTH,getdate(),zamova.data_zamovy)<1))[Продано за останній місяць] " +
            "from tovar t " +
            "left join partia on partia.nazva_tovaru=t.nazva " +
            "group by t.nazva,t.kilkist_u_partii,t.cina_partii;"
             , Properties.Settings.Default.DefaultConnection);
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.factoryDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.PIB". При необходимости она может быть перемещена или удалена.
            this.pIBTableAdapter.Fill(this.factoryDataSet.PIB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.syrovina". При необходимости она может быть перемещена или удалена.
            this.syrovinaTableAdapter.Fill(this.factoryDataSet.syrovina);
            tovarTableAdapter.Fill(factoryDataSet.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.vygotovlennya". При необходимости она может быть перемещена или удалена.
            this.vygotovlennyaTableAdapter.Fill(this.factoryDataSet.vygotovlennya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.posada". При необходимости она может быть перемещена или удалена.
            this.posadaTableAdapter.Fill(this.factoryDataSet.posada);
            userAdapter.Fill(userTable);
            userView.DataSource = userTable;
            productAdapter.Fill(productTable);
            productDataGridView.DataSource = productTable;
            zamovnykTableAdapter.Fill(factoryDataSet.zamovnyk);
            monthlyWages.Visible = false;
            hourlyWages.Visible = false;
            percentCommision.Visible = false;
            //posadaTableAdapter.Fill(factoryDataSet.posada);
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
                id = (int)customerView.SelectedRows[0].Cells[0].Value;
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

        private void updateCustomerFinal(object sender, EventArgs e)
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


        private void CustomerButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            CustomerPanel.Visible = true;
            CustomerButton.Enabled = false;
            UserPanel.Visible = false;
            UsersButton.Enabled = true;
            ProductPanel.Visible = false;
            ProductButton.Enabled = true;
            PositionPanel.Visible = false;
            PositionButton.Enabled = true;
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            CustomerPanel.Visible = false;
            CustomerButton.Enabled = true;
            UserPanel.Visible = true;
            UsersButton.Enabled = false; 
            ProductPanel.Visible = false;
            ProductButton.Enabled = true;
            PositionPanel.Visible = false;
            PositionButton.Enabled = true;
        }

        private void PositionButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            CustomerPanel.Visible = false;
            CustomerButton.Enabled = true;
            UserPanel.Visible = false;
            UsersButton.Enabled = true;
            ProductPanel.Visible = false;
            ProductButton.Enabled = true;
            PositionPanel.Visible = true;
            PositionButton.Enabled = false;
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            CustomerPanel.Visible = false;
            CustomerButton.Enabled = true;
            UserPanel.Visible = false;
            UsersButton.Enabled = true;
            ProductPanel.Visible = true;
            ProductButton.Enabled = false;
            PositionPanel.Visible = false;
            PositionButton.Enabled = true;
        }
        private void changeProductButton_Click(object sender, EventArgs e)
        {
            string name;
            try
            {
                name = (string)productDataGridView.SelectedCells[0].OwningRow.Cells[0].Value;
            }
            catch
            {
                name = (string)productDataGridView.SelectedRows[0].Cells[0].Value;
            }
            changeProductButton.Click += changeProductionButton_Click;
            changeProductButton.Click -= changeProductButton_Click;
            changeProductButton.Text = "Змінити виготовлення";
            deleteProductButton.Enabled = false;
            addProductButton.Click += changeProductButton_Final;
            addProductButton.Click -= addProductButton_Click;
            addProductButton.Text = "Завершити";
            productCountNumeric.Value = (int)productDataGridView.SelectedCells[0].OwningRow.Cells["Штук у партії"].Value;
            productNameTextBox.Text = name;
            productPriceNumeric.Value = (decimal)productDataGridView.SelectedCells[0].OwningRow.Cells["Ціна партії"].Value;
        }
        private void changeProductButton_Final(object sender, EventArgs e)
        {
            string name="";
            try
            {
                name = (string)productDataGridView.SelectedCells[0].OwningRow.Cells[0].Value;
            }
            catch
            {
            }
            try
            {
                tovarTableAdapter.UpdateQuery(productNameTextBox.Text, (int)productCountNumeric.Value, productPriceNumeric.Value, name);
            }
            finally
            {
                changeProductButton.Click -= changeProductionButton_Click;
                changeProductButton.Click += changeProductButton_Click;
                changeProductButton.Text = "Змінити";
                deleteProductButton.Enabled = true;
                addProductButton.Click -= changeProductButton_Final;
                addProductButton.Click += addProductButton_Click;
                addProductButton.Text = "Додати";
                productCountNumeric.Value = 0;
                productPriceNumeric.Value = 0;
                tovarTableAdapter.Update(factoryDataSet.tovar);
            }
            productTable.Clear();
            productAdapter.Fill(productTable);
        }
        private void changeProductionButton_Click(object sender, EventArgs e)
        {
            changeProductButton.Click -= changeProductionButton_Click;
            changeProductButton.Click += addProduction_Click;
            changeProductButton.Text = "Змінити кількість сировини";
            deleteCustomerButton.Enabled = true;
            deleteProductButton.Click += deleteProductButton_Click;
            deleteProductButton.Click -= deleteProductionButton_Click;
            deleteProductButton.Text = "Видалити сировину";
            addProductButton.Click += changeProductionButton_Final;
            addProductButton.Click -= addProductButton_Click;
            addProductButton.Text = "Завершити";
            productNameTextBox.ReadOnly = true;
            productCountNumeric.Visible = false;
            productPriceNumeric.Visible = false;
            label8.Text = "Назва сировини";
            label7.Text = "Кількість сировини(у кг)";
            materialComboBox.Visible = true;
            materialNumeric.Visible = true;
            materialNumeric.Value = 0;
            vygotovlennyaTableAdapter.Update(factoryDataSet.vygotovlennya);
            productTable.Reset();
            SqlDataAdapter productionAdapter = new SqlDataAdapter("select " +
                "nazva_syroviny [Назва сировини], " +
                "kilkist_syroviny [Кількість сировини на одну партію(у кг)] " +
                "from vygotovlennya " +
                $"where nazva_tovaru=N'{productNameTextBox.Text}'"
                 , Properties.Settings.Default.DefaultConnection);
            productionAdapter.Fill(productTable);
        }
        private void changeProductionButton_Final(object sender, EventArgs e)
        {
            changeProductButton.Click += changeProductionButton_Click;
            changeProductButton.Click -= addProduction_Click;
            changeProductButton.Text = "Змінити";
            deleteProductButton.Click += deleteProductButton_Click;
            deleteProductButton.Click -= deleteProductionButton_Click;
            deleteProductButton.Text = "Видалити";
            addProductButton.Click -= changeProductionButton_Final;
            addProductButton.Click += addProductButton_Click;
            addProductButton.Text = "Додати";
            productNameTextBox.ReadOnly = false;
            productCountNumeric.Visible = true;
            productPriceNumeric.Visible = true;
            label8.Text = "Кількість товарів у партії";
            label7.Text = "Ціна однієї партії";
            materialComboBox.Visible = false;
            materialNumeric.Visible = false;
            materialNumeric.Value = 0;
            vygotovlennyaTableAdapter.Update(factoryDataSet.vygotovlennya);
            vygotovlennyaTableAdapter.Fill(factoryDataSet.vygotovlennya);
            productTable.Reset();
            productAdapter.Fill(productTable);
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                tovarTableAdapter.Insert(productNameTextBox.Text, (int)productCountNumeric.Value, productPriceNumeric.Value);
            }
            finally
            {
                changeProductButton.Click += addProduction_Click;
                changeProductButton.Click -= changeProductButton_Click;
                deleteProductButton.Enabled = false;
                productCountNumeric.Value = 0;
                productCountNumeric.Visible = false;
                productPriceNumeric.Value = 0;
                productPriceNumeric.Visible = false;
                productNameTextBox.ReadOnly = true;
                label8.Text = "Назва сировини";
                label7.Text = "Кількість сировини(у кг)";
                materialComboBox.Visible = true;
                materialNumeric.Visible = true;
                addProductButton.Text = "Завершити";
                addProductButton.Click += addProductionButton_Click;
                addProductButton.Click -= addProductButton_Click;
                tovarTableAdapter.Update(factoryDataSet.tovar);
            }
            SqlDataAdapter productionAdapter = new SqlDataAdapter("select " +
                "nazva_syroviny [Назва сировини], " +
                "kilkist_syroviny [Кількість сировини на одну партію(у кг)] " +
                "from vygotovlennya " +
                $"where nazva_tovaru=N'{productNameTextBox.Text}'"
                 , Properties.Settings.Default.DefaultConnection);
            productTable.Reset();
            productionAdapter.Fill(productTable);
        }
        private void addProduction_Click(object sender, EventArgs e)
        {
            SqlDataAdapter productionAdapter = new SqlDataAdapter("select " +
                "nazva_syroviny [Назва сировини], " +
                "kilkist_syroviny [Кількість сировини на одну партію(у кг)] " +
                "from vygotovlennya " +
                $"where nazva_tovaru=N'{productNameTextBox.Text}'"
                 , Properties.Settings.Default.DefaultConnection);
            try 
            { 
                vygotovlennyaTableAdapter.Insert(productNameTextBox.Text, (string)materialComboBox.SelectedValue, (int)materialNumeric.Value);
            } 
            catch 
            {
                vygotovlennyaTableAdapter.UpdateQuery((int)materialNumeric.Value, productNameTextBox.Text, (string)materialComboBox.SelectedValue);
            }
            vygotovlennyaTableAdapter.Update(factoryDataSet.vygotovlennya); 
            productTable.Clear();
            productionAdapter.Fill(productTable);
        }
        private void addProductionButton_Click(object sender, EventArgs e)
        {
            deleteProductButton.Enabled = true;
            productDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            productDataGridView.AllowUserToAddRows=false;
            productDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            productCountNumeric.Visible = true;
            productPriceNumeric.Visible = true;
            productNameTextBox.ReadOnly = false;
            label8.Text = "Кількість товарів у партії";
            label7.Text = "Ціна однієї партії";
            materialComboBox.Visible = false;
            materialNumeric.Visible = false;
            addProductButton.Text = "Додати";
            addProductButton.Click -= addProductionButton_Click;
            addProductButton.Click += addProductButton_Click;
            vygotovlennyaTableAdapter.Update(factoryDataSet.vygotovlennya);
            productTable.Reset();
            productAdapter.Fill(productTable);
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            string name;
            try
            {
                name = (string)productDataGridView.SelectedCells[0].OwningRow.Cells[0].Value;
            }
            catch
            {
                name = (string)productDataGridView.SelectedRows[0].Cells[0].Value;
            }
            try
            {
                tovarTableAdapter.DeleteQuery(name);

            }
            finally
            {
                tovarTableAdapter.Update(factoryDataSet.tovar);
                productTable.Clear();
                productAdapter.Fill(productTable);
            }
        }
        private void deleteProductionButton_Click(object sender, EventArgs e)
        {
            string material;
            string product=productNameTextBox.Text;
            try
            {
                material = (string)productDataGridView.SelectedCells[0].OwningRow.Cells["Назва сировини"].Value;
            }
            catch
            {
                material = (string)productDataGridView.SelectedRows[0].Cells["Назва сировини"].Value;
            }
            try
            {
                vygotovlennyaTableAdapter.DeleteQuery(product, material);
            }
            finally
            {
                tovarTableAdapter.Update(factoryDataSet.tovar);
                productTable.Clear();
                productAdapter.Fill(productTable);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Show();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            percentCommision.Value = 0;
            monthlyWages.Value = 0;
            hourlyWages.Value = 0;
            switch (typeComboBox.SelectedItem)
            {
                case "Помісячна оплата + процент":
                    monthlyWages.Visible = true;
                    salaryLabel.Text = "Щомісячна ставка";
                    salaryLabel.Visible = true;
                    addPositionButton.Click -= addPositionButton_Click;
                    addPositionButton.Click -= percentCommision_show;
                    addPositionButton.Click += percentCommision_show;
                    addPositionButton.Text = "Процент";
                    break;
                case "Помісячна оплата":
                    addPositionButton.Click -= addPositionButton_Click;
                    addPositionButton.Click -= percentCommision_show;
                    addPositionButton.Click += addPositionButton_Click;
                    monthlyWages.Visible = true;
                    salaryLabel.Text = "Щомісячна ставка";
                    salaryLabel.Visible = true;
                    addPositionButton.Text = "Додати";
                    break;
                case "Погодинна оплата":
                    addPositionButton.Click -= addPositionButton_Click;
                    addPositionButton.Click -= percentCommision_show;
                    addPositionButton.Click += addPositionButton_Click;
                    hourlyWages.Visible = true;
                    percentCommision.Visible = false;
                    monthlyWages.Visible = false;
                    salaryLabel.Text = "Погодинна ставка";
                    salaryLabel.Visible = true;
                    addPositionButton.Text = "Додати";
                    break;
            }
        }

        private void percentCommision_show(object sender, EventArgs e)
        {
            monthlyWages.Visible = false;
            salaryLabel.Text = "Процент";
            if (positionChangeButton.Text == "Завершити редагування") addPositionButton.Enabled = false;
            addPositionButton.Text = "Додати";
            percentCommision.Visible = true;
            addPositionButton.Click += addPositionButton_Click;
            addPositionButton.Click -= percentCommision_show;
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            monthlyWages.Visible = false;
            hourlyWages.Visible = false;
            percentCommision.Visible = false;
            salaryLabel.Visible = false;
            try
            {
                posadaTableAdapter.Insert(positionNameTextBox.Text, (string)departmentComboBox.SelectedItem, monthlyWages.Value, percentCommision.Value, hourlyWages.Value, (string)typeComboBox.SelectedItem);
            }
            finally
            {
                posadaTableAdapter.Fill(factoryDataSet.posada);
            }
        }

        private void positionChangeButton_Click(object sender, EventArgs e)
        {
            positionDeleteButton.Enabled = false;
            positionNameTextBox.Text= (string)positionDataGridView.SelectedRows[0].Cells[0].Value; 
            departmentComboBox.SelectedItem = (string)positionDataGridView.SelectedRows[0].Cells[1].Value;
            typeComboBox.SelectedItem=(string)positionDataGridView.SelectedRows[0].Cells[5].Value;
            monthlyWages.Value=(decimal)positionDataGridView.SelectedRows[0].Cells[2].Value;
            hourlyWages.Value = (decimal)positionDataGridView.SelectedRows[0].Cells[4].Value;
            percentCommision.Value = (decimal)positionDataGridView.SelectedRows[0].Cells[3].Value;
            typeComboBox_SelectedIndexChanged(sender, e);
            addPositionButton.Click -= addPositionButton_Click;
            positionChangeButton.Click -= positionChangeButton_Click;
            positionChangeButton.Click += positionChangeFinal;
            positionChangeButton.Text = "Завершити редагування";
        }
        private void positionChangeFinal(object sender, EventArgs e)
        {
            positionDeleteButton.Enabled = true;
            string original = (string)positionDataGridView.SelectedRows[0].Cells[0].Value;
            try
            {
                posadaTableAdapter.UpdateQuery(positionNameTextBox.Text, departmentComboBox.Text, monthlyWages.Value, percentCommision.Value, hourlyWages.Value, typeComboBox.Text, original);
            }
            finally
            {
                positionChangeButton.Text = "Змінити";
                addPositionButton.Enabled = true;
                posadaTableAdapter.Fill(factoryDataSet.posada);
                positionChangeButton.Click += positionChangeButton_Click;
                positionChangeButton.Click -= positionChangeFinal;
            }
        }

        private void positionDeleteButton_Click(object sender, EventArgs e)
        {
            string original = (string)positionDataGridView.SelectedRows[0].Cells[0].Value; try
            {
                posadaTableAdapter.DeleteQuery(original);
                posadaTableAdapter.UpdateQuery(positionNameTextBox.Text, departmentComboBox.Text, monthlyWages.Value, percentCommision.Value, hourlyWages.Value, typeComboBox.Text, original);
            }
            finally
            {
                posadaTableAdapter.Fill(factoryDataSet.posada);
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBox1.Checked) usersTableAdapter.InsertQuery(loginTextBox.Text, passwordTextBox.Text, accessLevelComboBox.SelectedItem.ToString());
                else usersTableAdapter.Insert(loginTextBox.Text,passwordTextBox.Text,accessLevelComboBox.SelectedItem.ToString(),(int)userComboBox.SelectedValue);
            }
            finally
            {
                loginTextBox.Text="";
                passwordTextBox.Text = "";
                accessLevelComboBox.SelectedText = "";
                userComboBox.SelectedText = "";
            }
            usersTableAdapter.Update(factoryDataSet.users);
            userTable.Clear();
            userAdapter.Fill(userTable);
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                row = userView.SelectedCells[0].OwningRow;
            }
            catch
            {
                row = userView.SelectedRows[0];
            }
            loginTextBox.Text = (string)row.Cells["Логін"].Value;
            passwordTextBox.Text = (string)row.Cells["Пароль"].Value;
            accessLevelComboBox.SelectedText = (string)row.Cells["Рівень доступа"].Value;
            try
            {
                userComboBox.SelectedValue = (string)row.Cells["Номер працівника"].Value;
            }
            catch
            {
                checkBox1.Checked = false;
            }
            changeUserButton.Click -= changeUserButton_Click;
            changeUserButton.Click += changeUserFinal;
            changeUserButton.Text = "Cкінчити редагування";
            addUserButton.Enabled = false;
            deleteUserButton.Enabled = false;
        }

        private void changeUserFinal(object sender, EventArgs e)
        {
            string login;
            try
            {
                login = (string)userView.SelectedCells[0].OwningRow.Cells["Логін"].Value;
            }
            catch
            {
                login = (string)userView.SelectedRows[0].Cells["Логін"].Value;
            }
            try
            {
                if (!checkBox1.Checked) usersTableAdapter.UpdateQueryAnon(loginTextBox.Text, passwordTextBox.Text, accessLevelComboBox.SelectedItem.ToString(), login);
                else usersTableAdapter.UpdateQuery(loginTextBox.Text, passwordTextBox.Text, accessLevelComboBox.SelectedItem.ToString(), (int)userComboBox.SelectedValue,login);
            }
            catch
            {

            }
            finally
            {
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                accessLevelComboBox.SelectedText = "";
                userComboBox.SelectedText = "";
                checkBox1.Checked = true;
            }
            usersTableAdapter.Update(factoryDataSet.users);
            userTable.Clear();
            userAdapter.Fill(userTable);
            changeUserButton.Click += changeUserButton_Click;
            changeUserButton.Click -= changeUserFinal;
            changeUserButton.Text = "Редагувати";
            addUserButton.Enabled = true;
            deleteUserButton.Enabled = true;
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            string login;
            try
            {
                login = (string)userView.SelectedCells[0].OwningRow.Cells["Логін"].Value;
            }
            catch
            {
                login = (string)userView.SelectedRows[0].Cells["Логін"].Value;
            }
            usersTableAdapter.DeleteQuery(login);
            userTable.Clear();
            userAdapter.Fill(userTable);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            userComboBox.Visible = checkBox1.Checked;
        }
    }
}
