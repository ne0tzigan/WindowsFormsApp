using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Kernel;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font;


namespace WindowsFormsApp
{
    public partial class OrderReportForm : Form
    {
        int order_id;
        DataTable dataTable=new DataTable();
        public OrderReportForm(int id)
        {
            InitializeComponent();
            order_id = id;
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDataSet.order_view". При необходимости она может быть перемещена или удалена.
            this.order_viewTableAdapter.Fill(this.factoryDataSet.order_view);
            for (int i = 0; i < 5; i++) dataTable.Columns.Add();
            string query = $"select row_number() OVER(ORDER BY tovar.nazva ASC) number, tovar.nazva name, Count(partia.id_partii) [count], tovar.cina_partii price, sum(tovar.cina_partii) cost " +
                $"from zamova " +
                $"inner join partia on partia.id_zamovy=zamova.id_zamovy " +
                $"inner join tovar on partia.nazva_tovaru=tovar.nazva " +
                $"where zamova.id_zamovy={order_id} " +
                $"group by tovar.nazva,tovar.cina_partii,zamova.id_zamovy;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(Properties.Settings.Default.DefaultConnection)));
            dataAdapter.Fill(dataTable);
            SumLabel.Text = ((decimal)order_viewTableAdapter.ScalarQuery(order_id)).ToString("0.00");
            query = $"select zamovnyk.imya from zamovnyk inner join zamova on zamovnyk.id=zamova.id_zamovnyka where zamova.id_zamovy={order_id}";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.DefaultConnection);
            conn.Open();
            CustomerLabel.Text = $"{new SqlCommand(query, conn).ExecuteScalar()}";
            query = $"select PIB.PIB from users inner join PIB on users.id_pracyvnika=PIB.id where login='{Program.loginForm.LoginString}'and password='{Program.loginForm.PasswordString}'";
            ManagerLabel.Text = $"{new SqlCommand(query, conn).ExecuteScalar()}";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
            NowDateLabel.Text = "Дата: " + DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void PrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream($"./reports/orderReport{order_id}.pdf", FileMode.Create, FileAccess.Write)));
                Document document = new Document(pdfDocument);
                PdfFont font = PdfFontFactory.CreateFont(@"./fonts/times.ttf", PdfEncodings.IDENTITY_H);
                document.SetFontSize(20);
                document.SetFont(font);
                Paragraph Header = new Paragraph(label1.Text)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetBold();
                document.Add(Header);
                document.SetFont(font);
                Paragraph period = new Paragraph(label6.Text).Add(new Paragraph(ReportedDateLabel.Text).SetItalic().SetUnderline());
                document.Add(period);
                period = new Paragraph(label7.Text).Add(new Paragraph(CustomerLabel.Text).SetItalic().SetUnderline());
                document.Add(period);
                Table table = new Table(5, false);
                for (int i = 0; i < 5; i++) table.AddHeaderCell(new Cell()
                    .Add(new Paragraph(dataGridView1.Columns[i].HeaderText)));
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < 5; i++) table.AddCell(new Cell()
                        .Add(new Paragraph(row.Cells[i].Value.ToString())));
                }
                document.Add(table);
                period = new Paragraph(label3.Text).Add(new Paragraph(SumLabel.Text).SetItalic().SetUnderline());
                document.Add(period);
                period = new Paragraph(label5.Text).Add(new Paragraph(ManagerLabel.Text).SetItalic().SetUnderline()).Add((new Paragraph(label2.Text)
                    .Add(new Paragraph(CustomerTextBox.Text).SetItalic().SetUnderline())).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));
                document.Add(period);
                Paragraph date = new Paragraph(NowDateLabel.Text)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                document.Add(date);
                document.Close();
            }
            catch
            {
                MessageBox.Show("Будь ласка, вимкніть перегляд документу, котрий буде редагуватися");
            }
        }
    }
}
