
namespace WindowsFormsApp
{
    partial class OrderReportForm
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
            this.PrintReport = new System.Windows.Forms.Button();
            this.ManagerLabel = new System.Windows.Forms.TextBox();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NowDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReportedDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.factoryDataSet = new WindowsFormsApp.factoryDataSet();
            this.orderviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_viewTableAdapter = new WindowsFormsApp.factoryDataSetTableAdapters.order_viewTableAdapter();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintReport
            // 
            this.PrintReport.Location = new System.Drawing.Point(242, 653);
            this.PrintReport.Name = "PrintReport";
            this.PrintReport.Size = new System.Drawing.Size(149, 58);
            this.PrintReport.TabIndex = 12;
            this.PrintReport.Text = "Створити документ";
            this.PrintReport.UseVisualStyleBackColor = true;
            this.PrintReport.Click += new System.EventHandler(this.PrintReport_Click);
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.BackColor = System.Drawing.Color.White;
            this.ManagerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManagerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLabel.Location = new System.Drawing.Point(84, 556);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(224, 23);
            this.ManagerLabel.TabIndex = 12;
            this.ManagerLabel.Text = "   бла-бла-бла      ";
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.Color.White;
            this.ReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportPanel.Controls.Add(this.CustomerTextBox);
            this.ReportPanel.Controls.Add(this.SumLabel);
            this.ReportPanel.Controls.Add(this.label3);
            this.ReportPanel.Controls.Add(this.label7);
            this.ReportPanel.Controls.Add(this.CustomerLabel);
            this.ReportPanel.Controls.Add(this.label6);
            this.ReportPanel.Controls.Add(this.label2);
            this.ReportPanel.Controls.Add(this.dataGridView1);
            this.ReportPanel.Controls.Add(this.NowDateLabel);
            this.ReportPanel.Controls.Add(this.ManagerLabel);
            this.ReportPanel.Controls.Add(this.label5);
            this.ReportPanel.Controls.Add(this.ReportedDateLabel);
            this.ReportPanel.Controls.Add(this.label1);
            this.ReportPanel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ReportPanel.Location = new System.Drawing.Point(0, 2);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(632, 645);
            this.ReportPanel.TabIndex = 7;
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.BackColor = System.Drawing.Color.White;
            this.CustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTextBox.Location = new System.Drawing.Point(403, 557);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(224, 23);
            this.CustomerTextBox.TabIndex = 21;
            this.CustomerTextBox.Text = "____________________";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.Location = new System.Drawing.Point(80, 510);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(225, 22);
            this.SumLabel.TabIndex = 20;
            this.SumLabel.Text = "      344 000 000 000.00     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Итого:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Отримувач:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(134, 134);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(200, 22);
            this.CustomerLabel.TabIndex = 17;
            this.CustomerLabel.Text = "        хтось-там           ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Відправник: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Прийняв:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.count,
            this.price,
            this.cost});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(23, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 304);
            this.dataGridView1.TabIndex = 14;
            // 
            // NowDateLabel
            // 
            this.NowDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NowDateLabel.AutoSize = true;
            this.NowDateLabel.Location = new System.Drawing.Point(433, 610);
            this.NowDateLabel.Name = "NowDateLabel";
            this.NowDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NowDateLabel.Size = new System.Drawing.Size(56, 22);
            this.NowDateLabel.TabIndex = 13;
            this.NowDateLabel.Text = "Дата:";
            this.NowDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Надав:";
            // 
            // ReportedDateLabel
            // 
            this.ReportedDateLabel.AutoSize = true;
            this.ReportedDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportedDateLabel.Location = new System.Drawing.Point(145, 95);
            this.ReportedDateLabel.Name = "ReportedDateLabel";
            this.ReportedDateLabel.Size = new System.Drawing.Size(215, 22);
            this.ReportedDateLabel.TabIndex = 7;
            this.ReportedDateLabel.Text = "Виноробня \"Виноробня\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товарна накладна";
            // 
            // factoryDataSet
            // 
            this.factoryDataSet.DataSetName = "factoryDataSet";
            this.factoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderviewBindingSource
            // 
            this.orderviewBindingSource.DataMember = "order_view";
            this.orderviewBindingSource.DataSource = this.factoryDataSet;
            // 
            // order_viewTableAdapter
            // 
            this.order_viewTableAdapter.ClearBeforeFill = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "№";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 58;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Найменування";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 164;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Кількість";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count.Width = 120;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Ціна";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 79;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Вартість";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cost.Width = 113;
            // 
            // OrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 723);
            this.Controls.Add(this.PrintReport);
            this.Controls.Add(this.ReportPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderReportForm";
            this.Text = "OrderReportForm";
            this.Load += new System.EventHandler(this.OrderReportForm_Load);
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintReport;
        private System.Windows.Forms.TextBox ManagerLabel;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Label NowDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ReportedDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private factoryDataSet factoryDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource orderviewBindingSource;
        private factoryDataSetTableAdapters.order_viewTableAdapter order_viewTableAdapter;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}