
namespace WindowsFormsApp
{
    partial class PrintFinancialReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.NowDateLabel = new System.Windows.Forms.Label();
            this.AccountantBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PurchaseLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportedDateLabel = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrintReport = new System.Windows.Forms.Button();
            this.ReportPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЗВІТ";
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.Color.White;
            this.ReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportPanel.Controls.Add(this.NowDateLabel);
            this.ReportPanel.Controls.Add(this.AccountantBox);
            this.ReportPanel.Controls.Add(this.label5);
            this.ReportPanel.Controls.Add(this.tableLayoutPanel1);
            this.ReportPanel.Controls.Add(this.ReportedDateLabel);
            this.ReportPanel.Controls.Add(this.label1);
            this.ReportPanel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ReportPanel.Location = new System.Drawing.Point(0, 0);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(632, 645);
            this.ReportPanel.TabIndex = 1;
            // 
            // NowDateLabel
            // 
            this.NowDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NowDateLabel.AutoSize = true;
            this.NowDateLabel.Location = new System.Drawing.Point(470, 610);
            this.NowDateLabel.Name = "NowDateLabel";
            this.NowDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NowDateLabel.Size = new System.Drawing.Size(56, 22);
            this.NowDateLabel.TabIndex = 13;
            this.NowDateLabel.Text = "Дата:";
            this.NowDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountantBox
            // 
            this.AccountantBox.BackColor = System.Drawing.Color.White;
            this.AccountantBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountantBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline);
            this.AccountantBox.Location = new System.Drawing.Point(112, 556);
            this.AccountantBox.Name = "AccountantBox";
            this.AccountantBox.Size = new System.Drawing.Size(257, 23);
            this.AccountantBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Бухгалтер:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SalesLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PurchaseLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SalaryLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SumLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 357);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // SalesLabel
            // 
            this.SalesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(442, 230);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(15, 22);
            this.SalesLabel.TabIndex = 15;
            this.SalesLabel.Text = " ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Прибуток від продаж";
            // 
            // PurchaseLabel
            // 
            this.PurchaseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchaseLabel.AutoSize = true;
            this.PurchaseLabel.Location = new System.Drawing.Point(442, 154);
            this.PurchaseLabel.Name = "PurchaseLabel";
            this.PurchaseLabel.Size = new System.Drawing.Size(15, 22);
            this.PurchaseLabel.TabIndex = 13;
            this.PurchaseLabel.Text = " ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Витрати на закупівлі";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(442, 78);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(15, 22);
            this.SalaryLabel.TabIndex = 11;
            this.SalaryLabel.Text = " ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Виплати працівникам";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Загальні кошти(надані у грн.)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Загальний";
            // 
            // SumLabel
            // 
            this.SumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(442, 307);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(15, 22);
            this.SumLabel.TabIndex = 7;
            this.SumLabel.Text = " ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фінансові показники";
            // 
            // ReportedDateLabel
            // 
            this.ReportedDateLabel.AutoSize = true;
            this.ReportedDateLabel.Location = new System.Drawing.Point(12, 117);
            this.ReportedDateLabel.Name = "ReportedDateLabel";
            this.ReportedDateLabel.Size = new System.Drawing.Size(143, 22);
            this.ReportedDateLabel.TabIndex = 7;
            this.ReportedDateLabel.Text = "Звітний період:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(173, 651);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(141, 31);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(173, 688);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(141, 31);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Початкова дата -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 693);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кінцева дата -";
            // 
            // PrintReport
            // 
            this.PrintReport.Location = new System.Drawing.Point(399, 664);
            this.PrintReport.Name = "PrintReport";
            this.PrintReport.Size = new System.Drawing.Size(220, 40);
            this.PrintReport.TabIndex = 6;
            this.PrintReport.Text = "Створити документ";
            this.PrintReport.UseVisualStyleBackColor = true;
            this.PrintReport.Click += new System.EventHandler(this.PrintReport_Click);
            // 
            // PrintFinancialReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 723);
            this.Controls.Add(this.PrintReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.dateTimePickerStart);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PrintFinancialReportForm";
            this.Text = "Звіт";
            this.Load += new System.EventHandler(this.PrintFinancialReportForm_Load);
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PrintReport;
        private System.Windows.Forms.Label ReportedDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label PurchaseLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AccountantBox;
        private System.Windows.Forms.Label NowDateLabel;
    }
}