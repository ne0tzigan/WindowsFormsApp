
namespace WindowsFormsApp
{
    partial class HRForm
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
            this.NewWorkerButton = new System.Windows.Forms.Button();
            this.WorkerListButton = new System.Windows.Forms.Button();
            this.WorkerListPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PIBSearch = new System.Windows.Forms.ComboBox();
            this.pIBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDataSet = new WindowsFormsApp.factoryDataSet();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.WorkersView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pobatkoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanarodzhennyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracivnykiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewWorkerPanel = new System.Windows.Forms.Panel();
            this.posadaBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.patronimTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SubmitWorkerButton = new System.Windows.Forms.Button();
            this.posadaTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.posadaTableAdapter();
            this.pracivnykiTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.pracivnykiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pIBTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.PIBTableAdapter();
            this.WorkerListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracivnykiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posadaBindingSource)).BeginInit();
            this.NewWorkerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewWorkerButton
            // 
            this.NewWorkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NewWorkerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewWorkerButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.NewWorkerButton.Location = new System.Drawing.Point(60, 176);
            this.NewWorkerButton.Name = "NewWorkerButton";
            this.NewWorkerButton.Size = new System.Drawing.Size(180, 30);
            this.NewWorkerButton.TabIndex = 1;
            this.NewWorkerButton.Text = "Новий працівник";
            this.NewWorkerButton.UseVisualStyleBackColor = false;
            this.NewWorkerButton.Click += new System.EventHandler(this.NewWorkerButton_Click);
            // 
            // WorkerListButton
            // 
            this.WorkerListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WorkerListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkerListButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.WorkerListButton.Location = new System.Drawing.Point(51, 362);
            this.WorkerListButton.Name = "WorkerListButton";
            this.WorkerListButton.Size = new System.Drawing.Size(200, 30);
            this.WorkerListButton.TabIndex = 2;
            this.WorkerListButton.Text = "Список працівників";
            this.WorkerListButton.UseVisualStyleBackColor = false;
            this.WorkerListButton.Click += new System.EventHandler(this.WorkerListButton_Click);
            // 
            // WorkerListPanel
            // 
            this.WorkerListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkerListPanel.Controls.Add(this.checkBox1);
            this.WorkerListPanel.Controls.Add(this.PIBSearch);
            this.WorkerListPanel.Controls.Add(this.updateButton);
            this.WorkerListPanel.Controls.Add(this.deleteButton);
            this.WorkerListPanel.Controls.Add(this.WorkersView);
            this.WorkerListPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerListPanel.Location = new System.Drawing.Point(299, 1);
            this.WorkerListPanel.Name = "WorkerListPanel";
            this.WorkerListPanel.Size = new System.Drawing.Size(498, 497);
            this.WorkerListPanel.TabIndex = 0;
            this.WorkerListPanel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 405);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 28);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Пошук за ПІБ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PIBSearch
            // 
            this.PIBSearch.DataSource = this.pIBBindingSource;
            this.PIBSearch.DisplayMember = "PIB";
            this.PIBSearch.FormattingEnabled = true;
            this.PIBSearch.Location = new System.Drawing.Point(231, 405);
            this.PIBSearch.Name = "PIBSearch";
            this.PIBSearch.Size = new System.Drawing.Size(257, 32);
            this.PIBSearch.TabIndex = 6;
            this.PIBSearch.ValueMember = "id";
            this.PIBSearch.Visible = false;
            this.PIBSearch.SelectedIndexChanged += new System.EventHandler(this.PIBSearch_SelectedIndexChanged);
            this.PIBSearch.TextUpdate += new System.EventHandler(this.PIBSearch_SelectedIndexChanged);
            // 
            // pIBBindingSource
            // 
            this.pIBBindingSource.DataMember = "PIB";
            this.pIBBindingSource.DataSource = this.factoryDataSet;
            // 
            // factoryDataSet
            // 
            this.factoryDataSet.DataSetName = "factoryDataSet";
            this.factoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateButton.Location = new System.Drawing.Point(305, 446);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(140, 30);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Редагувати";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteButton.Location = new System.Drawing.Point(47, 446);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(140, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Звільнити";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // WorkersView
            // 
            this.WorkersView.AllowUserToAddRows = false;
            this.WorkersView.AllowUserToDeleteRows = false;
            this.WorkersView.AllowUserToOrderColumns = true;
            this.WorkersView.AllowUserToResizeRows = false;
            this.WorkersView.AutoGenerateColumns = false;
            this.WorkersView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.pobatkoviDataGridViewTextBoxColumn,
            this.telnomerDataGridViewTextBoxColumn,
            this.posadaDataGridViewTextBoxColumn,
            this.datanarodzhennyaDataGridViewTextBoxColumn});
            this.WorkersView.DataSource = this.pracivnykiBindingSource;
            this.WorkersView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.WorkersView.Location = new System.Drawing.Point(0, 0);
            this.WorkersView.Name = "WorkersView";
            this.WorkersView.RowHeadersVisible = false;
            this.WorkersView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.WorkersView.RowTemplate.Height = 24;
            this.WorkersView.Size = new System.Drawing.Size(494, 399);
            this.WorkersView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.familiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.imyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            this.imyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pobatkoviDataGridViewTextBoxColumn
            // 
            this.pobatkoviDataGridViewTextBoxColumn.DataPropertyName = "pobatkovi";
            this.pobatkoviDataGridViewTextBoxColumn.HeaderText = "По-батькові";
            this.pobatkoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pobatkoviDataGridViewTextBoxColumn.Name = "pobatkoviDataGridViewTextBoxColumn";
            this.pobatkoviDataGridViewTextBoxColumn.Width = 125;
            // 
            // telnomerDataGridViewTextBoxColumn
            // 
            this.telnomerDataGridViewTextBoxColumn.DataPropertyName = "tel_nomer";
            this.telnomerDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.telnomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telnomerDataGridViewTextBoxColumn.Name = "telnomerDataGridViewTextBoxColumn";
            this.telnomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // posadaDataGridViewTextBoxColumn
            // 
            this.posadaDataGridViewTextBoxColumn.DataPropertyName = "posada";
            this.posadaDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.posadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.posadaDataGridViewTextBoxColumn.Name = "posadaDataGridViewTextBoxColumn";
            this.posadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datanarodzhennyaDataGridViewTextBoxColumn
            // 
            this.datanarodzhennyaDataGridViewTextBoxColumn.DataPropertyName = "data_narodzhennya";
            this.datanarodzhennyaDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.datanarodzhennyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanarodzhennyaDataGridViewTextBoxColumn.Name = "datanarodzhennyaDataGridViewTextBoxColumn";
            this.datanarodzhennyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pracivnykiBindingSource
            // 
            this.pracivnykiBindingSource.DataMember = "pracivnyki";
            this.pracivnykiBindingSource.DataSource = this.factoryDataSet;
            // 
            // posadaBindingSource
            // 
            this.posadaBindingSource.DataMember = "posada";
            this.posadaBindingSource.DataSource = this.factoryDataSet;
            // 
            // NewWorkerPanel
            // 
            this.NewWorkerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewWorkerPanel.Controls.Add(this.posadaBox);
            this.NewWorkerPanel.Controls.Add(this.label10);
            this.NewWorkerPanel.Controls.Add(this.phoneNumTextBox);
            this.NewWorkerPanel.Controls.Add(this.label9);
            this.NewWorkerPanel.Controls.Add(this.label5);
            this.NewWorkerPanel.Controls.Add(this.label6);
            this.NewWorkerPanel.Controls.Add(this.label7);
            this.NewWorkerPanel.Controls.Add(this.label8);
            this.NewWorkerPanel.Controls.Add(this.patronimTextBox);
            this.NewWorkerPanel.Controls.Add(this.nameTextBox);
            this.NewWorkerPanel.Controls.Add(this.surnameTextBox);
            this.NewWorkerPanel.Controls.Add(this.dateOfBirth);
            this.NewWorkerPanel.Controls.Add(this.SubmitWorkerButton);
            this.NewWorkerPanel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWorkerPanel.Location = new System.Drawing.Point(299, 1);
            this.NewWorkerPanel.Name = "NewWorkerPanel";
            this.NewWorkerPanel.Size = new System.Drawing.Size(498, 497);
            this.NewWorkerPanel.TabIndex = 3;
            this.NewWorkerPanel.Visible = false;
            // 
            // posadaBox
            // 
            this.posadaBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.posadaBox.DataSource = this.posadaBindingSource;
            this.posadaBox.DisplayMember = "nazva";
            this.posadaBox.FormattingEnabled = true;
            this.posadaBox.Location = new System.Drawing.Point(182, 302);
            this.posadaBox.Name = "posadaBox";
            this.posadaBox.Size = new System.Drawing.Size(200, 32);
            this.posadaBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Телефон";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(182, 195);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(200, 31);
            this.phoneNumTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Посада";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата народження";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "По-батькові";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ім\'я";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Прізвище";
            // 
            // patronimTextBox
            // 
            this.patronimTextBox.Location = new System.Drawing.Point(182, 140);
            this.patronimTextBox.Name = "patronimTextBox";
            this.patronimTextBox.Size = new System.Drawing.Size(200, 31);
            this.patronimTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(182, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 31);
            this.nameTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(182, 29);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 31);
            this.surnameTextBox.TabIndex = 2;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(182, 252);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 31);
            this.dateOfBirth.TabIndex = 1;
            // 
            // SubmitWorkerButton
            // 
            this.SubmitWorkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubmitWorkerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitWorkerButton.Location = new System.Drawing.Point(348, 457);
            this.SubmitWorkerButton.Name = "SubmitWorkerButton";
            this.SubmitWorkerButton.Size = new System.Drawing.Size(143, 33);
            this.SubmitWorkerButton.TabIndex = 0;
            this.SubmitWorkerButton.Text = "Додати";
            this.SubmitWorkerButton.UseVisualStyleBackColor = false;
            this.SubmitWorkerButton.Click += new System.EventHandler(this.SubmitWorkerButton_Click);
            // 
            // posadaTableAdapter
            // 
            this.posadaTableAdapter.ClearBeforeFill = true;
            // 
            // pracivnykiTableAdapter
            // 
            this.pracivnykiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кадровий працівник:";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(12, 42);
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
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.crimean_wine_factory;
            this.pictureBox1.Location = new System.Drawing.Point(299, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pIBTableAdapter
            // 
            this.pIBTableAdapter.ClearBeforeFill = true;
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.WorkerListButton);
            this.Controls.Add(this.NewWorkerButton);
            this.Controls.Add(this.WorkerListPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewWorkerPanel);
            this.Name = "HRForm";
            this.Text = "Відділ кадрів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HRForm_FormClosed);
            this.Load += new System.EventHandler(this.HRForm_Load);
            this.WorkerListPanel.ResumeLayout(false);
            this.WorkerListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracivnykiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posadaBindingSource)).EndInit();
            this.NewWorkerPanel.ResumeLayout(false);
            this.NewWorkerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewWorkerButton;
        private System.Windows.Forms.Button WorkerListButton;
        private System.Windows.Forms.Panel WorkerListPanel;
        private System.Windows.Forms.Panel NewWorkerPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox patronimTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Button SubmitWorkerButton;
        private System.Windows.Forms.BindingSource posadaBindingSource;
        private factoryDataSetTableAdapters.posadaTableAdapter posadaTableAdapter;
        private factoryDataSetTableAdapters.pracivnykiTableAdapter pracivnykiTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView WorkersView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pobatkoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanarodzhennyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pracivnykiBindingSource;
        private factoryDataSet factoryDataSet;
        private System.Windows.Forms.ComboBox posadaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private factoryDataSetTableAdapters.PIBTableAdapter pIBTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox PIBSearch;
        private System.Windows.Forms.BindingSource pIBBindingSource;
    }
}