using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Kernel;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font;

namespace WindowsFormsApp
{
    public partial class PrintFinancialReportForm : Form
    {
        public PrintFinancialReportForm()
        {
            InitializeComponent();
        }
        private void PrintFinancialReportForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
            string query = String.Format("select id_pracyvnika from users where login='{0}'and password='{1}'", Program.loginForm.LoginString, Program.loginForm.PasswordString);
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
            {
                SqlCommand comm = new SqlCommand(query, defconn);
                defconn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                string id = " ";
                try
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        id = reader.GetInt32(0).ToString();
                    }
                }
                catch { return; }
                query = String.Format("select PIB from dbo.PIB where id={0}", id);
                comm.CommandText = query;
                reader.Close();
                reader = comm.ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string PIB = reader.GetString(0);
                        AccountantBox.Text=PIB;
                    }
                }
                catch { AccountantBox.Text = "          "; }
            }
            NowDateLabel.Text = String.Format("Дата: {0}",DateTime.Today.ToShortDateString());
        }

        private void PrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream($"./reports/report{dateTimePickerStart.Value.ToString("ddMMyy")}-{dateTimePickerEnd.Value.ToString("ddMMyy")}.pdf", FileMode.Create, FileAccess.Write)));
                Document document = new Document(pdfDocument);
                PdfFont font = PdfFontFactory.CreateFont(@"./fonts/times.ttf", PdfEncodings.IDENTITY_H);
                document.SetFontSize(20);
                document.SetFont(font);
                Paragraph Header = new Paragraph(label1.Text)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetBold();
                document.Add(Header);
                document.SetFont(font);
                Paragraph period = new Paragraph(ReportedDateLabel.Text);
                document.Add(period);
                Table table = new Table(2, false);
                Cell cell2 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(label2.Text));
                Cell cell3 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(label9.Text));
                Cell cell4 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(label10.Text));
                Cell cell5 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(SalaryLabel.Text));
                Cell cell6 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(label12.Text));
                Cell cell7 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(PurchaseLabel.Text));
                Cell cell8 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(label14.Text));
                Cell cell9 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(SalesLabel.Text));
                Cell cell10 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(label8.Text));
                Cell cell11 = new Cell(1, 1)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                      .Add(new Paragraph(SumLabel.Text));
                table.AddCell(cell2);
                table.AddCell(cell3);
                table.AddCell(cell4);
                table.AddCell(cell5);
                table.AddCell(cell6);
                table.AddCell(cell7);
                table.AddCell(cell8);
                table.AddCell(cell9);
                table.AddCell(cell10);
                table.AddCell(cell11);
                document.Add(table);
                Paragraph accountant = new Paragraph(label5.Text + AccountantBox.Text);
                document.Add(accountant);
                Paragraph date = new Paragraph(NowDateLabel.Text)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                document.Add(date); 
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка: "+ex.Message);
            }
            finally
            {
                MessageBox.Show("Документ для друку сформований");
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void UpdateTable() 
        {
            using (SqlConnection defconn = new SqlConnection(Properties.Settings.Default.DefaultConnection))
            {
                ReportedDateLabel.Text = String.Format("Звітній період: {0} - {1}", dateTimePickerStart.Value.ToShortDateString(), dateTimePickerEnd.Value.ToShortDateString());
                string StartDate = String.Format("{0}-{1}-{2}", dateTimePickerStart.Value.Year, dateTimePickerStart.Value.Month, dateTimePickerStart.Value.Day);
                string EndDate = String.Format("{0}-{1}-{2}", dateTimePickerEnd.Value.Year, dateTimePickerEnd.Value.Month, dateTimePickerEnd.Value.Day);
                string query = String.Format("select sum(cost) s from dbo.salary where data_vydachi>='{0}' and data_vydachi<='{1}'", StartDate, EndDate);
                SqlCommand comm = new SqlCommand(query, defconn);
                defconn.Open();
                decimal total_sum = 0;
                try
                {
                    SalaryLabel.Text = $"{comm.ExecuteScalar()}";
                    total_sum -= (decimal)comm.ExecuteScalar();
                }
                catch { SalaryLabel.Text = "0"; }
                finally { }
                query = String.Format("select sum(cost) s from dbo.purchase_view where data_zakupivli>='{0}' and data_zakupivli<='{1}'", StartDate, EndDate);
                comm.CommandText = query;
                try {
                    PurchaseLabel.Text = $"{comm.ExecuteScalar()}";
                    total_sum -= (decimal)comm.ExecuteScalar();
                }
                catch { PurchaseLabel.Text = "0"; }
                query = String.Format("select sum(cost) s from dbo.order_view where data_zamovy>='{0}' and data_zamovy<='{1}'", StartDate, EndDate);
                comm.CommandText = query;
                try
                {
                    SalesLabel.Text = $"{comm.ExecuteScalar()}";
                    total_sum += (decimal)comm.ExecuteScalar();
                }
                catch { SalesLabel.Text = "0"; }
                SumLabel.Text = total_sum.ToString("");
            }
        }
    }
}
