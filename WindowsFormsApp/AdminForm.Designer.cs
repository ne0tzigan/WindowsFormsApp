
namespace WindowsFormsApp
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.zamovnykTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.zamovnykTableAdapter();
            this.zamovnykBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDataSet = new WindowsFormsApp.factoryDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.tovarTableAdapter();
            this.zamovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.partiaTableAdapter();
            this.UsersButton = new System.Windows.Forms.Button();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.PositionButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.accessLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.pIBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userView = new System.Windows.Forms.DataGridView();
            this.PositionPanel = new System.Windows.Forms.Panel();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.percentCommision = new System.Windows.Forms.NumericUpDown();
            this.hourlyWages = new System.Windows.Forms.NumericUpDown();
            this.monthlyWages = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.positionNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.positionDeleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.positionChangeButton = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.positionDataGridView = new System.Windows.Forms.DataGridView();
            this.nazvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misstavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodynstavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipplatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.materialNumeric = new System.Windows.Forms.NumericUpDown();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.syrovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.productCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.changeProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.posadaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.posadaTableAdapter();
            this.vygotovlennyaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.vygotovlennyaTableAdapter();
            this.syrovinaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.syrovinaTableAdapter();
            this.pIBTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.PIBTableAdapter();
            this.usersTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovnykBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            this.CustomerPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            this.PositionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentCommision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyWages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyWages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posadaBindingSource)).BeginInit();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(299, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CustomerButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.Location = new System.Drawing.Point(37, 411);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(225, 45);
            this.CustomerButton.TabIndex = 11;
            this.CustomerButton.Text = "Замовники";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // zamovnykTableAdapter
            // 
            this.zamovnykTableAdapter.ClearBeforeFill = true;
            // 
            // zamovnykBindingSource
            // 
            this.zamovnykBindingSource.DataMember = "zamovnyk";
            this.zamovnykBindingSource.DataSource = this.factoryDataSet;
            // 
            // factoryDataSet
            // 
            this.factoryDataSet.DataSetName = "factoryDataSet";
            this.factoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.factoryDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // zamovaBindingSource
            // 
            this.zamovaBindingSource.DataMember = "zamova";
            this.zamovaBindingSource.DataSource = this.factoryDataSet;
            // 
            // partiaBindingSource
            // 
            this.partiaBindingSource.DataMember = "partia";
            this.partiaBindingSource.DataSource = this.factoryDataSet;
            // 
            // partiaTableAdapter
            // 
            this.partiaTableAdapter.ClearBeforeFill = true;
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UsersButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.Location = new System.Drawing.Point(37, 52);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(4);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(225, 45);
            this.UsersButton.TabIndex = 12;
            this.UsersButton.Text = "Користувачі";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // customerView
            // 
            this.customerView.AllowUserToAddRows = false;
            this.customerView.AllowUserToDeleteRows = false;
            this.customerView.AllowUserToOrderColumns = true;
            this.customerView.AllowUserToResizeRows = false;
            this.customerView.AutoGenerateColumns = false;
            this.customerView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.telnomerDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.customerView.DataSource = this.zamovnykBindingSource;
            this.customerView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerView.Location = new System.Drawing.Point(0, 0);
            this.customerView.Name = "customerView";
            this.customerView.RowHeadersVisible = false;
            this.customerView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.customerView.RowTemplate.Height = 24;
            this.customerView.Size = new System.Drawing.Size(502, 250);
            this.customerView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.imyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            this.imyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telnomerDataGridViewTextBoxColumn
            // 
            this.telnomerDataGridViewTextBoxColumn.DataPropertyName = "tel_nomer";
            this.telnomerDataGridViewTextBoxColumn.HeaderText = "Тел. номер";
            this.telnomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telnomerDataGridViewTextBoxColumn.Name = "telnomerDataGridViewTextBoxColumn";
            this.telnomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Е-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(174, 456);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(140, 30);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Додати";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(31, 266);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(140, 30);
            this.updateCustomerButton.TabIndex = 2;
            this.updateCustomerButton.Text = "Змінити";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 317);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 24);
            this.label.TabIndex = 6;
            this.label.Text = "Назва";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(310, 266);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(140, 30);
            this.deleteCustomerButton.TabIndex = 9;
            this.deleteCustomerButton.Text = "Видалити";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Номер телефона";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(250, 366);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 31);
            this.phoneTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(250, 415);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 31);
            this.emailTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(250, 314);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 31);
            this.nameTextBox.TabIndex = 17;
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerPanel.Controls.Add(this.nameTextBox);
            this.CustomerPanel.Controls.Add(this.emailTextBox);
            this.CustomerPanel.Controls.Add(this.label10);
            this.CustomerPanel.Controls.Add(this.phoneTextBox);
            this.CustomerPanel.Controls.Add(this.label9);
            this.CustomerPanel.Controls.Add(this.deleteCustomerButton);
            this.CustomerPanel.Controls.Add(this.label);
            this.CustomerPanel.Controls.Add(this.updateCustomerButton);
            this.CustomerPanel.Controls.Add(this.addCustomerButton);
            this.CustomerPanel.Controls.Add(this.customerView);
            this.CustomerPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPanel.Location = new System.Drawing.Point(299, 1);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(498, 497);
            this.CustomerPanel.TabIndex = 9;
            this.CustomerPanel.Visible = false;
            // 
            // PositionButton
            // 
            this.PositionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PositionButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionButton.Location = new System.Drawing.Point(37, 167);
            this.PositionButton.Margin = new System.Windows.Forms.Padding(4);
            this.PositionButton.Name = "PositionButton";
            this.PositionButton.Size = new System.Drawing.Size(225, 45);
            this.PositionButton.TabIndex = 13;
            this.PositionButton.Text = "Посади";
            this.PositionButton.UseVisualStyleBackColor = false;
            this.PositionButton.Click += new System.EventHandler(this.PositionButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProductButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.Location = new System.Drawing.Point(37, 288);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(225, 45);
            this.ProductButton.TabIndex = 14;
            this.ProductButton.Text = "Товар";
            this.ProductButton.UseVisualStyleBackColor = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserPanel.Controls.Add(this.accessLevelComboBox);
            this.UserPanel.Controls.Add(this.label3);
            this.UserPanel.Controls.Add(this.userComboBox);
            this.UserPanel.Controls.Add(this.checkBox1);
            this.UserPanel.Controls.Add(this.passwordTextBox);
            this.UserPanel.Controls.Add(this.label1);
            this.UserPanel.Controls.Add(this.loginTextBox);
            this.UserPanel.Controls.Add(this.label2);
            this.UserPanel.Controls.Add(this.deleteUserButton);
            this.UserPanel.Controls.Add(this.changeUserButton);
            this.UserPanel.Controls.Add(this.addUserButton);
            this.UserPanel.Controls.Add(this.userView);
            this.UserPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPanel.Location = new System.Drawing.Point(299, 1);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(498, 497);
            this.UserPanel.TabIndex = 15;
            this.UserPanel.Visible = false;
            // 
            // accessLevelComboBox
            // 
            this.accessLevelComboBox.FormattingEnabled = true;
            this.accessLevelComboBox.Items.AddRange(new object[] {
            "Admin",
            "Warehouse_worker",
            "HR",
            "Manager",
            "Accountant"});
            this.accessLevelComboBox.Location = new System.Drawing.Point(250, 363);
            this.accessLevelComboBox.Name = "accessLevelComboBox";
            this.accessLevelComboBox.Size = new System.Drawing.Size(200, 32);
            this.accessLevelComboBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Рівень доступа";
            // 
            // userComboBox
            // 
            this.userComboBox.DataSource = this.pIBBindingSource;
            this.userComboBox.DisplayMember = "PIB";
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(250, 413);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(200, 32);
            this.userComboBox.TabIndex = 19;
            this.userComboBox.ValueMember = "id";
            this.userComboBox.Visible = false;
            // 
            // pIBBindingSource
            // 
            this.pIBBindingSource.DataMember = "PIB";
            this.pIBBindingSource.DataSource = this.factoryDataSet;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 415);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 28);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Працівник";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(250, 313);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 31);
            this.passwordTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пароль";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(250, 264);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 31);
            this.loginTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Логін";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(310, 216);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(140, 30);
            this.deleteUserButton.TabIndex = 9;
            this.deleteUserButton.Text = "Видалити";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.Location = new System.Drawing.Point(31, 216);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(140, 30);
            this.changeUserButton.TabIndex = 2;
            this.changeUserButton.Text = "Змінити";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(174, 456);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(140, 30);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Додати";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userView
            // 
            this.userView.AllowUserToAddRows = false;
            this.userView.AllowUserToDeleteRows = false;
            this.userView.AllowUserToOrderColumns = true;
            this.userView.AllowUserToResizeRows = false;
            this.userView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userView.Location = new System.Drawing.Point(0, 0);
            this.userView.Name = "userView";
            this.userView.RowHeadersVisible = false;
            this.userView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.userView.RowTemplate.Height = 24;
            this.userView.Size = new System.Drawing.Size(502, 209);
            this.userView.TabIndex = 0;
            // 
            // PositionPanel
            // 
            this.PositionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PositionPanel.Controls.Add(this.salaryLabel);
            this.PositionPanel.Controls.Add(this.percentCommision);
            this.PositionPanel.Controls.Add(this.hourlyWages);
            this.PositionPanel.Controls.Add(this.monthlyWages);
            this.PositionPanel.Controls.Add(this.typeComboBox);
            this.PositionPanel.Controls.Add(this.departmentComboBox);
            this.PositionPanel.Controls.Add(this.positionNameTextBox);
            this.PositionPanel.Controls.Add(this.label4);
            this.PositionPanel.Controls.Add(this.label5);
            this.PositionPanel.Controls.Add(this.positionDeleteButton);
            this.PositionPanel.Controls.Add(this.label6);
            this.PositionPanel.Controls.Add(this.positionChangeButton);
            this.PositionPanel.Controls.Add(this.addPositionButton);
            this.PositionPanel.Controls.Add(this.positionDataGridView);
            this.PositionPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionPanel.Location = new System.Drawing.Point(299, 1);
            this.PositionPanel.Name = "PositionPanel";
            this.PositionPanel.Size = new System.Drawing.Size(498, 497);
            this.PositionPanel.TabIndex = 16;
            this.PositionPanel.Visible = false;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(27, 421);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(155, 24);
            this.salaryLabel.TabIndex = 23;
            this.salaryLabel.Text = "Щомісячна ставка";
            this.salaryLabel.Visible = false;
            // 
            // percentCommision
            // 
            this.percentCommision.DecimalPlaces = 3;
            this.percentCommision.Location = new System.Drawing.Point(250, 420);
            this.percentCommision.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentCommision.Name = "percentCommision";
            this.percentCommision.Size = new System.Drawing.Size(200, 31);
            this.percentCommision.TabIndex = 22;
            // 
            // hourlyWages
            // 
            this.hourlyWages.DecimalPlaces = 2;
            this.hourlyWages.Location = new System.Drawing.Point(250, 422);
            this.hourlyWages.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.hourlyWages.Name = "hourlyWages";
            this.hourlyWages.Size = new System.Drawing.Size(200, 31);
            this.hourlyWages.TabIndex = 21;
            // 
            // monthlyWages
            // 
            this.monthlyWages.DecimalPlaces = 2;
            this.monthlyWages.Location = new System.Drawing.Point(250, 419);
            this.monthlyWages.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.monthlyWages.Name = "monthlyWages";
            this.monthlyWages.Size = new System.Drawing.Size(200, 31);
            this.monthlyWages.TabIndex = 20;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Помісячна оплата + процент",
            "Помісячна оплата",
            "Погодинна оплата"});
            this.typeComboBox.Location = new System.Drawing.Point(250, 367);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(200, 32);
            this.typeComboBox.TabIndex = 19;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Виробництво",
            "Фінанси",
            "Відділ кадрів",
            "Продаж",
            "Керівництво"});
            this.departmentComboBox.Location = new System.Drawing.Point(250, 318);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(200, 32);
            this.departmentComboBox.TabIndex = 18;
            // 
            // positionNameTextBox
            // 
            this.positionNameTextBox.Location = new System.Drawing.Point(250, 267);
            this.positionNameTextBox.Name = "positionNameTextBox";
            this.positionNameTextBox.Size = new System.Drawing.Size(200, 31);
            this.positionNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тип платні";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Відділ";
            // 
            // positionDeleteButton
            // 
            this.positionDeleteButton.Location = new System.Drawing.Point(310, 219);
            this.positionDeleteButton.Name = "positionDeleteButton";
            this.positionDeleteButton.Size = new System.Drawing.Size(140, 30);
            this.positionDeleteButton.TabIndex = 9;
            this.positionDeleteButton.Text = "Видалити";
            this.positionDeleteButton.UseVisualStyleBackColor = true;
            this.positionDeleteButton.Click += new System.EventHandler(this.positionDeleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Назва";
            // 
            // positionChangeButton
            // 
            this.positionChangeButton.Location = new System.Drawing.Point(31, 219);
            this.positionChangeButton.Name = "positionChangeButton";
            this.positionChangeButton.Size = new System.Drawing.Size(140, 30);
            this.positionChangeButton.TabIndex = 2;
            this.positionChangeButton.Text = "Змінити";
            this.positionChangeButton.UseVisualStyleBackColor = true;
            this.positionChangeButton.Click += new System.EventHandler(this.positionChangeButton_Click);
            // 
            // addPositionButton
            // 
            this.addPositionButton.Location = new System.Drawing.Point(174, 456);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(140, 30);
            this.addPositionButton.TabIndex = 1;
            this.addPositionButton.Text = "Додати";
            this.addPositionButton.UseVisualStyleBackColor = true;
            this.addPositionButton.Click += new System.EventHandler(this.addPositionButton_Click);
            // 
            // positionDataGridView
            // 
            this.positionDataGridView.AllowUserToAddRows = false;
            this.positionDataGridView.AllowUserToDeleteRows = false;
            this.positionDataGridView.AllowUserToOrderColumns = true;
            this.positionDataGridView.AllowUserToResizeRows = false;
            this.positionDataGridView.AutoGenerateColumns = false;
            this.positionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvaDataGridViewTextBoxColumn,
            this.otdelDataGridViewTextBoxColumn,
            this.misstavkaDataGridViewTextBoxColumn,
            this.procentDataGridViewTextBoxColumn,
            this.hodynstavkaDataGridViewTextBoxColumn,
            this.tipplatyDataGridViewTextBoxColumn});
            this.positionDataGridView.DataSource = this.posadaBindingSource;
            this.positionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.positionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.positionDataGridView.Name = "positionDataGridView";
            this.positionDataGridView.RowHeadersVisible = false;
            this.positionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.positionDataGridView.RowTemplate.Height = 24;
            this.positionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.positionDataGridView.Size = new System.Drawing.Size(502, 209);
            this.positionDataGridView.TabIndex = 0;
            // 
            // nazvaDataGridViewTextBoxColumn
            // 
            this.nazvaDataGridViewTextBoxColumn.DataPropertyName = "nazva";
            this.nazvaDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.nazvaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazvaDataGridViewTextBoxColumn.Name = "nazvaDataGridViewTextBoxColumn";
            this.nazvaDataGridViewTextBoxColumn.Width = 125;
            // 
            // otdelDataGridViewTextBoxColumn
            // 
            this.otdelDataGridViewTextBoxColumn.DataPropertyName = "otdel";
            this.otdelDataGridViewTextBoxColumn.HeaderText = "Відділ";
            this.otdelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otdelDataGridViewTextBoxColumn.Name = "otdelDataGridViewTextBoxColumn";
            this.otdelDataGridViewTextBoxColumn.Width = 125;
            // 
            // misstavkaDataGridViewTextBoxColumn
            // 
            this.misstavkaDataGridViewTextBoxColumn.DataPropertyName = "mis_stavka";
            this.misstavkaDataGridViewTextBoxColumn.HeaderText = "Щомісячна ставка";
            this.misstavkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.misstavkaDataGridViewTextBoxColumn.Name = "misstavkaDataGridViewTextBoxColumn";
            this.misstavkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Процент";
            this.procentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.Width = 125;
            // 
            // hodynstavkaDataGridViewTextBoxColumn
            // 
            this.hodynstavkaDataGridViewTextBoxColumn.DataPropertyName = "hodyn_stavka";
            this.hodynstavkaDataGridViewTextBoxColumn.HeaderText = "Погодинна ставка";
            this.hodynstavkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hodynstavkaDataGridViewTextBoxColumn.Name = "hodynstavkaDataGridViewTextBoxColumn";
            this.hodynstavkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipplatyDataGridViewTextBoxColumn
            // 
            this.tipplatyDataGridViewTextBoxColumn.DataPropertyName = "tip_platy";
            this.tipplatyDataGridViewTextBoxColumn.HeaderText = "Тип плати";
            this.tipplatyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipplatyDataGridViewTextBoxColumn.Name = "tipplatyDataGridViewTextBoxColumn";
            this.tipplatyDataGridViewTextBoxColumn.Width = 125;
            // 
            // posadaBindingSource
            // 
            this.posadaBindingSource.DataMember = "posada";
            this.posadaBindingSource.DataSource = this.factoryDataSet;
            // 
            // ProductPanel
            // 
            this.ProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductPanel.Controls.Add(this.materialNumeric);
            this.ProductPanel.Controls.Add(this.materialComboBox);
            this.ProductPanel.Controls.Add(this.productPriceNumeric);
            this.ProductPanel.Controls.Add(this.productCountNumeric);
            this.ProductPanel.Controls.Add(this.productNameTextBox);
            this.ProductPanel.Controls.Add(this.label7);
            this.ProductPanel.Controls.Add(this.label8);
            this.ProductPanel.Controls.Add(this.deleteProductButton);
            this.ProductPanel.Controls.Add(this.label11);
            this.ProductPanel.Controls.Add(this.changeProductButton);
            this.ProductPanel.Controls.Add(this.addProductButton);
            this.ProductPanel.Controls.Add(this.productDataGridView);
            this.ProductPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPanel.Location = new System.Drawing.Point(299, 1);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(498, 497);
            this.ProductPanel.TabIndex = 17;
            this.ProductPanel.Visible = false;
            // 
            // materialNumeric
            // 
            this.materialNumeric.Location = new System.Drawing.Point(250, 416);
            this.materialNumeric.Name = "materialNumeric";
            this.materialNumeric.Size = new System.Drawing.Size(200, 31);
            this.materialNumeric.TabIndex = 21;
            this.materialNumeric.Visible = false;
            // 
            // materialComboBox
            // 
            this.materialComboBox.DataSource = this.syrovinaBindingSource;
            this.materialComboBox.DisplayMember = "nazva";
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(250, 366);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(200, 32);
            this.materialComboBox.TabIndex = 20;
            this.materialComboBox.ValueMember = "nazva";
            this.materialComboBox.Visible = false;
            // 
            // syrovinaBindingSource
            // 
            this.syrovinaBindingSource.DataMember = "syrovina";
            this.syrovinaBindingSource.DataSource = this.factoryDataSet;
            // 
            // productPriceNumeric
            // 
            this.productPriceNumeric.DecimalPlaces = 2;
            this.productPriceNumeric.Location = new System.Drawing.Point(250, 416);
            this.productPriceNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.productPriceNumeric.Name = "productPriceNumeric";
            this.productPriceNumeric.Size = new System.Drawing.Size(200, 31);
            this.productPriceNumeric.TabIndex = 19;
            // 
            // productCountNumeric
            // 
            this.productCountNumeric.Location = new System.Drawing.Point(250, 367);
            this.productCountNumeric.Name = "productCountNumeric";
            this.productCountNumeric.Size = new System.Drawing.Size(200, 31);
            this.productCountNumeric.TabIndex = 18;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(250, 314);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 31);
            this.productNameTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ціна однієї партії";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Кількість товарів у партії";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(310, 266);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(155, 32);
            this.deleteProductButton.TabIndex = 9;
            this.deleteProductButton.Text = "Видалити";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Назва";
            // 
            // changeProductButton
            // 
            this.changeProductButton.Location = new System.Drawing.Point(31, 266);
            this.changeProductButton.Name = "changeProductButton";
            this.changeProductButton.Size = new System.Drawing.Size(164, 32);
            this.changeProductButton.TabIndex = 2;
            this.changeProductButton.Text = "Змінити";
            this.changeProductButton.UseVisualStyleBackColor = true;
            this.changeProductButton.Click += new System.EventHandler(this.changeProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(174, 456);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(140, 30);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Додати";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(502, 250);
            this.productDataGridView.TabIndex = 0;
            // 
            // posadaTableAdapter
            // 
            this.posadaTableAdapter.ClearBeforeFill = true;
            // 
            // vygotovlennyaTableAdapter
            // 
            this.vygotovlennyaTableAdapter.ClearBeforeFill = true;
            // 
            // syrovinaTableAdapter
            // 
            this.syrovinaTableAdapter.ClearBeforeFill = true;
            // 
            // pIBTableAdapter
            // 
            this.pIBTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.PositionButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.PositionPanel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovnykBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            this.PositionPanel.ResumeLayout(false);
            this.PositionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentCommision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyWages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyWages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posadaBindingSource)).EndInit();
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CustomerButton;
        private factoryDataSetTableAdapters.zamovnykTableAdapter zamovnykTableAdapter;
        private System.Windows.Forms.BindingSource zamovnykBindingSource;
        private factoryDataSet factoryDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private factoryDataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.BindingSource zamovaBindingSource;
        private System.Windows.Forms.BindingSource partiaBindingSource;
        private factoryDataSetTableAdapters.partiaTableAdapter partiaTableAdapter;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Button PositionButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView userView;
        private System.Windows.Forms.Panel PositionPanel;
        private System.Windows.Forms.TextBox positionNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button positionDeleteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button positionChangeButton;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.DataGridView positionDataGridView;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button changeProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource posadaBindingSource;
        private factoryDataSetTableAdapters.posadaTableAdapter posadaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn misstavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodynstavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipplatyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown productPriceNumeric;
        private System.Windows.Forms.NumericUpDown productCountNumeric;
        private factoryDataSetTableAdapters.vygotovlennyaTableAdapter vygotovlennyaTableAdapter;
        private factoryDataSetTableAdapters.syrovinaTableAdapter syrovinaTableAdapter;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.NumericUpDown percentCommision;
        private System.Windows.Forms.NumericUpDown hourlyWages;
        private System.Windows.Forms.NumericUpDown monthlyWages;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource pIBBindingSource;
        private factoryDataSetTableAdapters.PIBTableAdapter pIBTableAdapter;
        private System.Windows.Forms.ComboBox accessLevelComboBox;
        private System.Windows.Forms.Label label3;
        private factoryDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.NumericUpDown materialNumeric;
        private System.Windows.Forms.BindingSource syrovinaBindingSource;
    }
}