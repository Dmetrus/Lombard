using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Excel2 = Microsoft.Office.Interop.Excel;

namespace Lombard
{
    public partial class Main : Form
    {
        
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databaselom.mdf;Integrated Security=True";

        string dostup;

        public Main()
        {
            InitializeComponent();
        }

        public void Dost(string user)
        {
            dostup = user;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ювелирныеИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jew dlw = new jew();
            this.Hide();
            dlw.Dost(dostup);
            dlw.ShowDialog();
            Close();

        }

        private void техникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tech dlg = new tech();
            this.Hide();
            dlg.Dost(dostup);
            dlg.ShowDialog();
            Close();
        }

        public void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.Techdeal". При необходимости она может быть перемещена или удалена.
            this.techdealTableAdapter.Fill(this.databaselomDataSet.Techdeal);  
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.Jewdeal". При необходимости она может быть перемещена или удалена.
            this.jewdealTableAdapter.Fill(this.databaselomDataSet.Jewdeal);

            if (dostup == "Пользователь")
            {
                сделкаToolStripMenuItem.Visible = false;
                выходныеДокументыToolStripMenuItem.Visible=false;
            }

            string query =
               "SELECT " +
               "[Techdeal].[ID_Tdeal], " +
               "[User].[Fam], " +
               "[User].[Name], " +
               "[Tech].[Name_tech], " +
               "[Tech].[Price], " +
               "[Techdeal].[Obrdeal] " +
               "FROM " +
               "[Techdeal], " +
               "[Tech], " +
               "[User] " +
               "WHERE " +
               "([Techdeal].[Tovar_id]=[Tech].[ID_Tech]) AND" +
               "([Techdeal].[User_id]=[User].[ID_User]) ";
            Zapros(query);
            string query1 =
               "SELECT " +
               "[Jewdeal].[ID_Jdeal], " +
               "[User].[Fam], " +
               "[User].[Name], " +
               "[Jew].[Name_tov], " +
               "[Jew].[Price], " +
               "[Jewdeal].[Obrdeal] " +
               "FROM " +
               "[Jewdeal], " +
               "[Jew], " +
               "[User] " +
               "WHERE " +
               "([Jewdeal].[Tovar_id]=[Jew].[ID_Jew]) AND" +
               "([Jewdeal].[User_id]=[User].[ID_User]) ";
            Zapros2(query1);

        }
        private void Zapros(string query)
        {
            dataGridView1.Rows.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString()+ " ₽";
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void Zapros2(string query)
        {
            dataGridView2.Rows.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString()+ " ₽";
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView2.Rows.Add(s);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ювелирныеИзделияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addjdeal brl = new addjdeal();
            brl.Owner = this;
            brl.Show();
        }

        private void техникаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addtdeal bri = new addtdeal();
            bri.Owner = this;
            bri.Show();
        }

        private void ювелирныеИзделияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var xlApp = new Excel.Application();
            xlApp.Visible = true;

            
            Microsoft.Office.Interop.Excel.Workbook wBook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;

           
            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)wBook.Sheets[1];
            

            xlSheet.Cells[1, 1] = "ID";
            xlSheet.Cells[1, 2] = "Фамилия";
            xlSheet.Cells[1, 3] = "Имя";
            xlSheet.Cells[1, 4] = "Название товара";
            xlSheet.Cells[1, 5] = "Цена";
            xlSheet.Cells[1, 6] = "Состояние сделки";

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }
            xlSheet.Cells.HorizontalAlignment = 3;
            xlApp.Visible = true;
        }

        private void техникаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var xlApp = new Excel2.Application();
            xlApp.Visible = true;


            Microsoft.Office.Interop.Excel.Workbook wBook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;


            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)wBook.Sheets[1];


            xlSheet.Cells[1, 1] = "ID";
            xlSheet.Cells[1, 2] = "Фамилия";
            xlSheet.Cells[1, 3] = "Имя";
            xlSheet.Cells[1, 4] = "Название товара";
            xlSheet.Cells[1, 5] = "Цена";
            xlSheet.Cells[1, 6] = "Состояние сделки";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            xlSheet.Cells.HorizontalAlignment = 3;
            xlApp.Visible = true;
        }
    }
}
