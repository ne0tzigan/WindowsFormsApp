
namespace WindowsFormsApp
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.managerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnOrdersButton = new System.Windows.Forms.Button();
            this.OwnOrders = new System.Windows.Forms.Panel();
            this.orferReportButton = new System.Windows.Forms.Button();
            this.lastDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.changeOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.OrdersView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.zamovnykBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDataSet = new WindowsFormsApp.factoryDataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilkist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewOrderButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.changeItemButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsCheckBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instanceCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.generalCountLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.NewOrder = new System.Windows.Forms.Panel();
            this.zamovnykTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.zamovnykTableAdapter();
            this.tovarTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.tovarTableAdapter();
            this.zamovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamovaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.zamovaTableAdapter();
            this.partiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.partiaTableAdapter();
            this.order_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_viewTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.order_viewTableAdapter();
            this.orderviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerListPanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIBTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.PIBTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OwnOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovnykBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instanceCount)).BeginInit();
            this.NewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zamovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderviewBindingSource)).BeginInit();
            this.CustomerListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NewOrderButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.NewOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewOrderButton.Location = new System.Drawing.Point(43, 217);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(225, 45);
            this.NewOrderButton.TabIndex = 1;
            this.NewOrderButton.Text = "Нове замовлення";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NewCustomerButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerButton.Location = new System.Drawing.Point(43, 347);
            this.NewCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(225, 45);
            this.NewCustomerButton.TabIndex = 2;
            this.NewCustomerButton.Text = "Новий замовник";
            this.NewCustomerButton.UseVisualStyleBackColor = false;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(12, 33);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managerLabel.Size = new System.Drawing.Size(186, 24);
            this.managerLabel.TabIndex = 3;
            this.managerLabel.Text = "________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Менеджер:";
            // 
            // OwnOrdersButton
            // 
            this.OwnOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OwnOrdersButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.OwnOrdersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OwnOrdersButton.Location = new System.Drawing.Point(43, 88);
            this.OwnOrdersButton.Margin = new System.Windows.Forms.Padding(4);
            this.OwnOrdersButton.Name = "OwnOrdersButton";
            this.OwnOrdersButton.Size = new System.Drawing.Size(225, 45);
            this.OwnOrdersButton.TabIndex = 0;
            this.OwnOrdersButton.Text = "Ваші замовлення";
            this.OwnOrdersButton.UseVisualStyleBackColor = false;
            this.OwnOrdersButton.Click += new System.EventHandler(this.OwnOrdersButton_Click);
            // 
            // OwnOrders
            // 
            this.OwnOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OwnOrders.Controls.Add(this.orferReportButton);
            this.OwnOrders.Controls.Add(this.lastDateTimePicker);
            this.OwnOrders.Controls.Add(this.firstDateTimePicker);
            this.OwnOrders.Controls.Add(this.label8);
            this.OwnOrders.Controls.Add(this.label7);
            this.OwnOrders.Controls.Add(this.percentLabel);
            this.OwnOrders.Controls.Add(this.splitter1);
            this.OwnOrders.Controls.Add(this.changeOrderButton);
            this.OwnOrders.Controls.Add(this.deleteOrderButton);
            this.OwnOrders.Controls.Add(this.OrdersView);
            this.OwnOrders.Location = new System.Drawing.Point(299, 1);
            this.OwnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.OwnOrders.Name = "OwnOrders";
            this.OwnOrders.Size = new System.Drawing.Size(498, 497);
            this.OwnOrders.TabIndex = 7;
            this.OwnOrders.Visible = false;
            // 
            // orferReportButton
            // 
            this.orferReportButton.Location = new System.Drawing.Point(347, 349);
            this.orferReportButton.Name = "orferReportButton";
            this.orferReportButton.Size = new System.Drawing.Size(102, 35);
            this.orferReportButton.TabIndex = 15;
            this.orferReportButton.Text = "Звіт";
            this.orferReportButton.UseVisualStyleBackColor = true;
            this.orferReportButton.Click += new System.EventHandler(this.orferReportButton_Click);
            // 
            // lastDateTimePicker
            // 
            this.lastDateTimePicker.Location = new System.Drawing.Point(282, 447);
            this.lastDateTimePicker.Name = "lastDateTimePicker";
            this.lastDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.lastDateTimePicker.TabIndex = 14;
            this.lastDateTimePicker.ValueChanged += new System.EventHandler(this.lastDateTimePicker_ValueChanged);
            // 
            // firstDateTimePicker
            // 
            this.firstDateTimePicker.Location = new System.Drawing.Point(36, 447);
            this.firstDateTimePicker.Name = "firstDateTimePicker";
            this.firstDateTimePicker.Size = new System.Drawing.Size(183, 31);
            this.firstDateTimePicker.TabIndex = 13;
            this.firstDateTimePicker.ValueChanged += new System.EventHandler(this.firstDateTimePicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "По:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "З:";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(24, 408);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(195, 24);
            this.percentLabel.TabIndex = 9;
            this.percentLabel.Text = "Процент за проміжок: ";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 395);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(494, 98);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.AccessibleName = "";
            this.changeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeOrderButton.Location = new System.Drawing.Point(191, 348);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(102, 37);
            this.changeOrderButton.TabIndex = 8;
            this.changeOrderButton.Text = "Змінити";
            this.changeOrderButton.UseVisualStyleBackColor = false;
            this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.AccessibleName = "";
            this.deleteOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteOrderButton.Location = new System.Drawing.Point(42, 348);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(102, 37);
            this.deleteOrderButton.TabIndex = 7;
            this.deleteOrderButton.Text = "Видалити";
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // OrdersView
            // 
            this.OrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersView.Location = new System.Drawing.Point(7, 9);
            this.OrdersView.Name = "OrdersView";
            this.OrdersView.RowHeadersWidth = 51;
            this.OrdersView.RowTemplate.Height = 24;
            this.OrdersView.Size = new System.Drawing.Size(480, 320);
            this.OrdersView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Замовник:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.zamovnykBindingSource;
            this.customerComboBox.DisplayMember = "imya";
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(94, 50);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(121, 32);
            this.customerComboBox.TabIndex = 4;
            this.customerComboBox.ValueMember = "id";
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
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Good,
            this.kilkist,
            this.sum});
            this.dataGridView.Location = new System.Drawing.Point(14, 186);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(473, 203);
            this.dataGridView.TabIndex = 6;
            // 
            // Good
            // 
            this.Good.DataPropertyName = "Товар";
            this.Good.HeaderText = "Товар";
            this.Good.MinimumWidth = 6;
            this.Good.Name = "Good";
            this.Good.Width = 125;
            // 
            // kilkist
            // 
            this.kilkist.DataPropertyName = "Кількість";
            this.kilkist.HeaderText = "Кількість";
            this.kilkist.MinimumWidth = 6;
            this.kilkist.Name = "kilkist";
            this.kilkist.Width = 125;
            // 
            // sum
            // 
            this.sum.DataPropertyName = "Вартість";
            this.sum.HeaderText = "Вартість";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.Width = 125;
            // 
            // addNewOrderButton
            // 
            this.addNewOrderButton.AccessibleName = "";
            this.addNewOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addNewOrderButton.Location = new System.Drawing.Point(385, 453);
            this.addNewOrderButton.Name = "addNewOrderButton";
            this.addNewOrderButton.Size = new System.Drawing.Size(102, 37);
            this.addNewOrderButton.TabIndex = 0;
            this.addNewOrderButton.Text = "Зберегти";
            this.addNewOrderButton.UseVisualStyleBackColor = false;
            this.addNewOrderButton.Click += new System.EventHandler(this.addNewOrderButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.AccessibleName = "";
            this.deleteItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deleteItemButton.Location = new System.Drawing.Point(42, 395);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(102, 37);
            this.deleteItemButton.TabIndex = 7;
            this.deleteItemButton.Text = "Видалити";
            this.deleteItemButton.UseVisualStyleBackColor = false;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // changeItemButton
            // 
            this.changeItemButton.AccessibleName = "";
            this.changeItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeItemButton.Location = new System.Drawing.Point(354, 395);
            this.changeItemButton.Name = "changeItemButton";
            this.changeItemButton.Size = new System.Drawing.Size(102, 37);
            this.changeItemButton.TabIndex = 8;
            this.changeItemButton.Text = "Змінити";
            this.changeItemButton.UseVisualStyleBackColor = false;
            this.changeItemButton.Click += new System.EventHandler(this.changeItemButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Товар:";
            // 
            // goodsCheckBox
            // 
            this.goodsCheckBox.DataSource = this.tovarBindingSource;
            this.goodsCheckBox.DisplayMember = "nazva";
            this.goodsCheckBox.FormattingEnabled = true;
            this.goodsCheckBox.Location = new System.Drawing.Point(78, 98);
            this.goodsCheckBox.Name = "goodsCheckBox";
            this.goodsCheckBox.Size = new System.Drawing.Size(121, 32);
            this.goodsCheckBox.TabIndex = 10;
            this.goodsCheckBox.ValueMember = "nazva";
            this.goodsCheckBox.SelectedIndexChanged += new System.EventHandler(this.goodsCheckBox_SelectedIndexChanged);
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.factoryDataSet;
            // 
            // instanceCount
            // 
            this.instanceCount.Location = new System.Drawing.Point(368, 99);
            this.instanceCount.Name = "instanceCount";
            this.instanceCount.Size = new System.Drawing.Size(120, 31);
            this.instanceCount.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Кількість партій:";
            // 
            // addItemButton
            // 
            this.addItemButton.AccessibleName = "";
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addItemButton.Location = new System.Drawing.Point(191, 143);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(102, 37);
            this.addItemButton.TabIndex = 14;
            this.addItemButton.Text = "Додати";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(3, 6);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(236, 24);
            this.orderIdLabel.TabIndex = 15;
            this.orderIdLabel.Text = "Порядковий номер замови:";
            // 
            // generalCountLabel
            // 
            this.generalCountLabel.AutoSize = true;
            this.generalCountLabel.Location = new System.Drawing.Point(10, 454);
            this.generalCountLabel.Name = "generalCountLabel";
            this.generalCountLabel.Size = new System.Drawing.Size(158, 24);
            this.generalCountLabel.TabIndex = 16;
            this.generalCountLabel.Text = "Загальна вартість:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(282, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата:";
            // 
            // NewOrder
            // 
            this.NewOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewOrder.Controls.Add(this.label6);
            this.NewOrder.Controls.Add(this.dateTimePicker);
            this.NewOrder.Controls.Add(this.generalCountLabel);
            this.NewOrder.Controls.Add(this.orderIdLabel);
            this.NewOrder.Controls.Add(this.addItemButton);
            this.NewOrder.Controls.Add(this.label4);
            this.NewOrder.Controls.Add(this.instanceCount);
            this.NewOrder.Controls.Add(this.goodsCheckBox);
            this.NewOrder.Controls.Add(this.label3);
            this.NewOrder.Controls.Add(this.changeItemButton);
            this.NewOrder.Controls.Add(this.deleteItemButton);
            this.NewOrder.Controls.Add(this.addNewOrderButton);
            this.NewOrder.Controls.Add(this.dataGridView);
            this.NewOrder.Controls.Add(this.customerComboBox);
            this.NewOrder.Controls.Add(this.label1);
            this.NewOrder.Location = new System.Drawing.Point(299, 1);
            this.NewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(498, 497);
            this.NewOrder.TabIndex = 3;
            // 
            // zamovnykTableAdapter
            // 
            this.zamovnykTableAdapter.ClearBeforeFill = true;
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
            // zamovaTableAdapter
            // 
            this.zamovaTableAdapter.ClearBeforeFill = true;
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
            // order_viewBindingSource
            // 
            this.order_viewBindingSource.DataMember = "order_view";
            this.order_viewBindingSource.DataSource = this.factoryDataSet;
            // 
            // order_viewTableAdapter
            // 
            this.order_viewTableAdapter.ClearBeforeFill = true;
            // 
            // orderviewBindingSource
            // 
            this.orderviewBindingSource.DataMember = "order_view";
            this.orderviewBindingSource.DataSource = this.factoryDataSet;
            // 
            // CustomerListPanel
            // 
            this.CustomerListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerListPanel.Controls.Add(this.nameTextBox);
            this.CustomerListPanel.Controls.Add(this.emailTextBox);
            this.CustomerListPanel.Controls.Add(this.label10);
            this.CustomerListPanel.Controls.Add(this.phoneTextBox);
            this.CustomerListPanel.Controls.Add(this.label9);
            this.CustomerListPanel.Controls.Add(this.deleteCustomerButton);
            this.CustomerListPanel.Controls.Add(this.label);
            this.CustomerListPanel.Controls.Add(this.updateCustomerButton);
            this.CustomerListPanel.Controls.Add(this.addCustomerButton);
            this.CustomerListPanel.Controls.Add(this.customerView);
            this.CustomerListPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerListPanel.Location = new System.Drawing.Point(299, 1);
            this.CustomerListPanel.Name = "CustomerListPanel";
            this.CustomerListPanel.Size = new System.Drawing.Size(498, 497);
            this.CustomerListPanel.TabIndex = 8;
            this.CustomerListPanel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(250, 314);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 31);
            this.nameTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(250, 415);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 31);
            this.emailTextBox.TabIndex = 16;
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
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(250, 366);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 31);
            this.phoneTextBox.TabIndex = 14;
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 317);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 24);
            this.label.TabIndex = 6;
            this.label.Text = "Назва";
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
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // pIBTableAdapter
            // 
            this.pIBTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.OwnOrdersButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.CustomerListPanel);
            this.Controls.Add(this.OwnOrders);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.Text = "Менеджер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.OwnOrders.ResumeLayout(false);
            this.OwnOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovnykBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instanceCount)).EndInit();
            this.NewOrder.ResumeLayout(false);
            this.NewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zamovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderviewBindingSource)).EndInit();
            this.CustomerListPanel.ResumeLayout(false);
            this.CustomerListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Label managerLabel;
        private factoryDataSet factoryDataSet;
        private System.Windows.Forms.BindingSource zamovnykBindingSource;
        private factoryDataSetTableAdapters.zamovnykTableAdapter zamovnykTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private factoryDataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.BindingSource zamovaBindingSource;
        private factoryDataSetTableAdapters.zamovaTableAdapter zamovaTableAdapter;
        private System.Windows.Forms.BindingSource partiaBindingSource;
        private factoryDataSetTableAdapters.partiaTableAdapter partiaTableAdapter;
        private System.Windows.Forms.BindingSource order_viewBindingSource;
        private factoryDataSetTableAdapters.order_viewTableAdapter order_viewTableAdapter;
        private System.Windows.Forms.Button OwnOrdersButton;
        private System.Windows.Forms.Panel OwnOrders;
        private System.Windows.Forms.Button changeOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.BindingSource orderviewBindingSource;
        private System.Windows.Forms.DataGridView OrdersView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addNewOrderButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button changeItemButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox goodsCheckBox;
        private System.Windows.Forms.NumericUpDown instanceCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label generalCountLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel NewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilkist;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DateTimePicker lastDateTimePicker;
        private System.Windows.Forms.DateTimePicker firstDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel CustomerListPanel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.TextBox nameTextBox;
        private factoryDataSetTableAdapters.PIBTableAdapter pIBTableAdapter;
        private System.Windows.Forms.Button orferReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}