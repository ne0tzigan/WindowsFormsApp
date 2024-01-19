
namespace WindowsFormsApp
{
    partial class ProductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionForm));
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.productSortComboBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDataSet = new WindowsFormsApp.factoryDataSet();
            this.productSortCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.orderedGoodsComboBox = new System.Windows.Forms.ComboBox();
            this.zamovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderedGoodsCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteInstanceButton = new System.Windows.Forms.Button();
            this.productionView = new System.Windows.Forms.DataGridView();
            this.idpartiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvatovaruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavygotovlennyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzamovyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addInstancePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.instancesNumber = new System.Windows.Forms.NumericUpDown();
            this.addInstanceButton = new System.Windows.Forms.Button();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialView = new System.Windows.Forms.DataGridView();
            this.nazvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unayavnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syrovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instanceViewButton = new System.Windows.Forms.Button();
            this.newProductButton = new System.Windows.Forms.Button();
            this.partiaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.partiaTableAdapter();
            this.tovarTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.tovarTableAdapter();
            this.syrovinaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.syrovinaTableAdapter();
            this.zamovaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.zamovaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pIBTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.PIBTableAdapter();
            this.ProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiaBindingSource)).BeginInit();
            this.addInstancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instancesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductsPanel.Controls.Add(this.label5);
            this.ProductsPanel.Controls.Add(this.productSortComboBox);
            this.ProductsPanel.Controls.Add(this.productSortCheckBox);
            this.ProductsPanel.Controls.Add(this.dateCheckBox);
            this.ProductsPanel.Controls.Add(this.label4);
            this.ProductsPanel.Controls.Add(this.dateTimePickerEnd);
            this.ProductsPanel.Controls.Add(this.dateTimePickerStart);
            this.ProductsPanel.Controls.Add(this.orderedGoodsComboBox);
            this.ProductsPanel.Controls.Add(this.orderedGoodsCheckBox);
            this.ProductsPanel.Controls.Add(this.deleteInstanceButton);
            this.ProductsPanel.Controls.Add(this.productionView);
            this.ProductsPanel.Location = new System.Drawing.Point(299, 1);
            this.ProductsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(498, 497);
            this.ProductsPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Фільтрувати за:";
            // 
            // productSortComboBox
            // 
            this.productSortComboBox.DataSource = this.tovarBindingSource;
            this.productSortComboBox.DisplayMember = "nazva";
            this.productSortComboBox.FormattingEnabled = true;
            this.productSortComboBox.Location = new System.Drawing.Point(177, 453);
            this.productSortComboBox.Name = "productSortComboBox";
            this.productSortComboBox.Size = new System.Drawing.Size(121, 32);
            this.productSortComboBox.TabIndex = 15;
            this.productSortComboBox.ValueMember = "nazva";
            this.productSortComboBox.Visible = false;
            this.productSortComboBox.SelectedIndexChanged += new System.EventHandler(this.Sort);
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.factoryDataSet;
            // 
            // factoryDataSet
            // 
            this.factoryDataSet.DataSetName = "factoryDataSet";
            this.factoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSortCheckBox
            // 
            this.productSortCheckBox.AutoSize = true;
            this.productSortCheckBox.Location = new System.Drawing.Point(21, 455);
            this.productSortCheckBox.Name = "productSortCheckBox";
            this.productSortCheckBox.Size = new System.Drawing.Size(103, 28);
            this.productSortCheckBox.TabIndex = 14;
            this.productSortCheckBox.Text = "Товаром";
            this.productSortCheckBox.UseVisualStyleBackColor = true;
            this.productSortCheckBox.CheckedChanged += new System.EventHandler(this.productSortCheckBox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(21, 415);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(87, 28);
            this.dateCheckBox.TabIndex = 13;
            this.dateCheckBox.Text = "Датою";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            this.label4.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Checked = false;
            this.dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(347, 411);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(141, 31);
            this.dateTimePickerEnd.TabIndex = 11;
            this.dateTimePickerEnd.Visible = false;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.Sort);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10F);
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(177, 411);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(141, 31);
            this.dateTimePickerStart.TabIndex = 10;
            this.dateTimePickerStart.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Visible = false;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.Sort);
            // 
            // orderedGoodsComboBox
            // 
            this.orderedGoodsComboBox.DataSource = this.zamovaBindingSource;
            this.orderedGoodsComboBox.DisplayMember = "id_zamovy";
            this.orderedGoodsComboBox.FormattingEnabled = true;
            this.orderedGoodsComboBox.Location = new System.Drawing.Point(177, 369);
            this.orderedGoodsComboBox.Name = "orderedGoodsComboBox";
            this.orderedGoodsComboBox.Size = new System.Drawing.Size(121, 32);
            this.orderedGoodsComboBox.TabIndex = 8;
            this.orderedGoodsComboBox.ValueMember = "id_zamovy";
            this.orderedGoodsComboBox.Visible = false;
            this.orderedGoodsComboBox.SelectedIndexChanged += new System.EventHandler(this.Sort);
            // 
            // zamovaBindingSource
            // 
            this.zamovaBindingSource.DataMember = "zamova";
            this.zamovaBindingSource.DataSource = this.factoryDataSet;
            // 
            // orderedGoodsCheckBox
            // 
            this.orderedGoodsCheckBox.AutoSize = true;
            this.orderedGoodsCheckBox.Location = new System.Drawing.Point(21, 373);
            this.orderedGoodsCheckBox.Name = "orderedGoodsCheckBox";
            this.orderedGoodsCheckBox.Size = new System.Drawing.Size(117, 28);
            this.orderedGoodsCheckBox.TabIndex = 7;
            this.orderedGoodsCheckBox.Text = "Замовлені";
            this.orderedGoodsCheckBox.UseVisualStyleBackColor = true;
            this.orderedGoodsCheckBox.CheckedChanged += new System.EventHandler(this.orderedGoodsCheckBox_CheckedChanged);
            // 
            // deleteInstanceButton
            // 
            this.deleteInstanceButton.Location = new System.Drawing.Point(163, 299);
            this.deleteInstanceButton.Name = "deleteInstanceButton";
            this.deleteInstanceButton.Size = new System.Drawing.Size(160, 35);
            this.deleteInstanceButton.TabIndex = 6;
            this.deleteInstanceButton.Text = "Списати партію";
            this.deleteInstanceButton.UseVisualStyleBackColor = true;
            // 
            // productionView
            // 
            this.productionView.AutoGenerateColumns = false;
            this.productionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpartiiDataGridViewTextBoxColumn,
            this.nazvatovaruDataGridViewTextBoxColumn,
            this.datavygotovlennyaDataGridViewTextBoxColumn,
            this.idzamovyDataGridViewTextBoxColumn});
            this.productionView.DataSource = this.partiaBindingSource;
            this.productionView.Location = new System.Drawing.Point(12, 9);
            this.productionView.Name = "productionView";
            this.productionView.RowHeadersVisible = false;
            this.productionView.RowHeadersWidth = 51;
            this.productionView.RowTemplate.Height = 24;
            this.productionView.Size = new System.Drawing.Size(476, 280);
            this.productionView.TabIndex = 0;
            // 
            // idpartiiDataGridViewTextBoxColumn
            // 
            this.idpartiiDataGridViewTextBoxColumn.DataPropertyName = "id_partii";
            this.idpartiiDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idpartiiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpartiiDataGridViewTextBoxColumn.Name = "idpartiiDataGridViewTextBoxColumn";
            this.idpartiiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpartiiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazvatovaruDataGridViewTextBoxColumn
            // 
            this.nazvatovaruDataGridViewTextBoxColumn.DataPropertyName = "nazva_tovaru";
            this.nazvatovaruDataGridViewTextBoxColumn.HeaderText = "Назва товару";
            this.nazvatovaruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazvatovaruDataGridViewTextBoxColumn.Name = "nazvatovaruDataGridViewTextBoxColumn";
            this.nazvatovaruDataGridViewTextBoxColumn.Width = 125;
            // 
            // datavygotovlennyaDataGridViewTextBoxColumn
            // 
            this.datavygotovlennyaDataGridViewTextBoxColumn.DataPropertyName = "data_vygotovlennya";
            this.datavygotovlennyaDataGridViewTextBoxColumn.HeaderText = "Дата виготовлення";
            this.datavygotovlennyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datavygotovlennyaDataGridViewTextBoxColumn.Name = "datavygotovlennyaDataGridViewTextBoxColumn";
            this.datavygotovlennyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idzamovyDataGridViewTextBoxColumn
            // 
            this.idzamovyDataGridViewTextBoxColumn.DataPropertyName = "id_zamovy";
            this.idzamovyDataGridViewTextBoxColumn.HeaderText = "Номер замови";
            this.idzamovyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idzamovyDataGridViewTextBoxColumn.Name = "idzamovyDataGridViewTextBoxColumn";
            this.idzamovyDataGridViewTextBoxColumn.Width = 125;
            // 
            // partiaBindingSource
            // 
            this.partiaBindingSource.DataMember = "partia";
            this.partiaBindingSource.DataSource = this.factoryDataSet;
            // 
            // addInstancePanel
            // 
            this.addInstancePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addInstancePanel.Controls.Add(this.label3);
            this.addInstancePanel.Controls.Add(this.instancesNumber);
            this.addInstancePanel.Controls.Add(this.addInstanceButton);
            this.addInstancePanel.Controls.Add(this.productComboBox);
            this.addInstancePanel.Controls.Add(this.label1);
            this.addInstancePanel.Controls.Add(this.label2);
            this.addInstancePanel.Controls.Add(this.dateTimePicker);
            this.addInstancePanel.Controls.Add(this.materialView);
            this.addInstancePanel.Location = new System.Drawing.Point(299, 1);
            this.addInstancePanel.Margin = new System.Windows.Forms.Padding(4);
            this.addInstancePanel.Name = "addInstancePanel";
            this.addInstancePanel.Size = new System.Drawing.Size(498, 497);
            this.addInstancePanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Кількість партій";
            // 
            // instancesNumber
            // 
            this.instancesNumber.Location = new System.Drawing.Point(241, 412);
            this.instancesNumber.Name = "instancesNumber";
            this.instancesNumber.Size = new System.Drawing.Size(203, 31);
            this.instancesNumber.TabIndex = 11;
            // 
            // addInstanceButton
            // 
            this.addInstanceButton.Location = new System.Drawing.Point(163, 452);
            this.addInstanceButton.Name = "addInstanceButton";
            this.addInstanceButton.Size = new System.Drawing.Size(160, 35);
            this.addInstanceButton.TabIndex = 10;
            this.addInstanceButton.Text = "Додати";
            this.addInstanceButton.UseVisualStyleBackColor = true;
            this.addInstanceButton.Click += new System.EventHandler(this.addInstanceButton_Click);
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.tovarBindingSource1;
            this.productComboBox.DisplayMember = "nazva";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(241, 302);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(203, 32);
            this.productComboBox.TabIndex = 6;
            this.productComboBox.ValueMember = "nazva";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // tovarBindingSource1
            // 
            this.tovarBindingSource1.DataMember = "tovar";
            this.tovarBindingSource1.DataSource = this.factoryDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Назва товару";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата виготовлення";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(241, 358);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 31);
            this.dateTimePicker.TabIndex = 7;
            // 
            // materialView
            // 
            this.materialView.AllowUserToAddRows = false;
            this.materialView.AutoGenerateColumns = false;
            this.materialView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvaDataGridViewTextBoxColumn,
            this.Column1,
            this.unayavnostiDataGridViewTextBoxColumn});
            this.materialView.DataSource = this.syrovinaBindingSource;
            this.materialView.Location = new System.Drawing.Point(12, 12);
            this.materialView.Name = "materialView";
            this.materialView.RowHeadersVisible = false;
            this.materialView.RowHeadersWidth = 51;
            this.materialView.RowTemplate.Height = 24;
            this.materialView.Size = new System.Drawing.Size(476, 277);
            this.materialView.TabIndex = 0;
            // 
            // nazvaDataGridViewTextBoxColumn
            // 
            this.nazvaDataGridViewTextBoxColumn.DataPropertyName = "nazva";
            this.nazvaDataGridViewTextBoxColumn.HeaderText = "Назва сировини";
            this.nazvaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazvaDataGridViewTextBoxColumn.Name = "nazvaDataGridViewTextBoxColumn";
            this.nazvaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kilkist_syroviny";
            this.Column1.HeaderText = "Необхідна кількість(кг)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // unayavnostiDataGridViewTextBoxColumn
            // 
            this.unayavnostiDataGridViewTextBoxColumn.DataPropertyName = "u_nayavnosti";
            this.unayavnostiDataGridViewTextBoxColumn.HeaderText = "Кількість у наявності(кг)";
            this.unayavnostiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unayavnostiDataGridViewTextBoxColumn.Name = "unayavnostiDataGridViewTextBoxColumn";
            this.unayavnostiDataGridViewTextBoxColumn.Width = 125;
            // 
            // syrovinaBindingSource
            // 
            this.syrovinaBindingSource.DataMember = "syrovina";
            this.syrovinaBindingSource.DataSource = this.factoryDataSet;
            // 
            // instanceViewButton
            // 
            this.instanceViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.instanceViewButton.Location = new System.Drawing.Point(74, 128);
            this.instanceViewButton.Name = "instanceViewButton";
            this.instanceViewButton.Size = new System.Drawing.Size(153, 37);
            this.instanceViewButton.TabIndex = 2;
            this.instanceViewButton.Text = "Склад товарів";
            this.instanceViewButton.UseVisualStyleBackColor = false;
            this.instanceViewButton.Click += new System.EventHandler(this.instanceViewButton_Click);
            // 
            // newProductButton
            // 
            this.newProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newProductButton.Location = new System.Drawing.Point(74, 295);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(153, 37);
            this.newProductButton.TabIndex = 3;
            this.newProductButton.Text = "Додати товари";
            this.newProductButton.UseVisualStyleBackColor = false;
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
            // 
            // partiaTableAdapter
            // 
            this.partiaTableAdapter.ClearBeforeFill = true;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // syrovinaTableAdapter
            // 
            this.syrovinaTableAdapter.ClearBeforeFill = true;
            // 
            // zamovaTableAdapter
            // 
            this.zamovaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Складський робітник:";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(12, 33);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managerLabel.Size = new System.Drawing.Size(186, 24);
            this.managerLabel.TabIndex = 6;
            this.managerLabel.Text = "________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 497);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pIBTableAdapter
            // 
            this.pIBTableAdapter.ClearBeforeFill = true;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.instanceViewButton);
            this.Controls.Add(this.addInstancePanel);
            this.Controls.Add(this.ProductsPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionForm";
            this.Text = "ProductionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductionForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.ProductsPanel.ResumeLayout(false);
            this.ProductsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiaBindingSource)).EndInit();
            this.addInstancePanel.ResumeLayout(false);
            this.addInstancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instancesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.Panel addInstancePanel;
        private System.Windows.Forms.Button instanceViewButton;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.DataGridView productionView;
        private factoryDataSet factoryDataSet;
        private System.Windows.Forms.BindingSource partiaBindingSource;
        private factoryDataSetTableAdapters.partiaTableAdapter partiaTableAdapter;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private factoryDataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.Button deleteInstanceButton;
        private System.Windows.Forms.DataGridView materialView;
        private System.Windows.Forms.BindingSource syrovinaBindingSource;
        private factoryDataSetTableAdapters.syrovinaTableAdapter syrovinaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown instancesNumber;
        private System.Windows.Forms.Button addInstanceButton;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox orderedGoodsComboBox;
        private System.Windows.Forms.CheckBox orderedGoodsCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvatovaruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavygotovlennyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzamovyDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox productSortComboBox;
        private System.Windows.Forms.CheckBox productSortCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource zamovaBindingSource;
        private factoryDataSetTableAdapters.zamovaTableAdapter zamovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unayavnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tovarBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private factoryDataSetTableAdapters.PIBTableAdapter pIBTableAdapter;
    }
}