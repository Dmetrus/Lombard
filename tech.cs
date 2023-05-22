using Lombard.DatabaselomDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lombard
{
    public partial class tech : Form
    {
        string dostup;
        public tech()
        {
            InitializeComponent();
           
        }

        public void Dost(string user)
        {
            dostup = user;
        }

        private void tech_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.Tech". При необходимости она может быть перемещена или удалена.
            this.techTableAdapter.Fill(this.databaselomDataSet.Tech);
            comboBox1.SelectedIndex = 0;
            combosos.SelectedIndex = 0;
            comboad.SelectedIndex = 0;
            if (dostup == "Пользователь")
            {
                adel.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main dlg = new Main();
            this.Hide();
            dlg.ShowDialog();
            Close();
        }

        private void addbut_Click(object sender, EventArgs e)
        {
            bool usl = namez.Text.Length > 0 && rice.Text.Length > 0;
            if (usl)
            {
                if (this != null)
                {
                    DataRow nRow = databaselomDataSet.Tables[2].NewRow();
                    nRow[0] = 0;
                    nRow[1] = namez.Text;
                    nRow[2] = rice.Text;
                    nRow[3] = combosos.Text;
                    nRow[4] = comboad.Text;

                    databaselomDataSet.Tables[2].Rows.Add(nRow);
                    techTableAdapter.Update(databaselomDataSet.Tech);
                    databaselomDataSet.Tables[2].AcceptChanges();
                    tech_Load(sender, e);

                    namez.Text = "";
                    rice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void delbut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    if (MessageBox.Show("Вы точно хотите удалить данный товар?", "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM [Tech] WHERE ID_Tech = @pID", connection);
                        command.Parameters.Add(new SqlParameter("@pID", this.dataGridView1.CurrentRow.Cells["iDTechDataGridViewTextBoxColumn"].Value));
                        command.ExecuteNonQuery();
                        tech_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите строку, которую хотите удалить!", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {                     
                techBindingSource.Filter = "[Name_tech] LIKE'" + textBox1.Text + "%'";
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Товара с данным именем отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.Sort(iDTechDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 1:
                    dataGridView1.Sort(nametechDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 2:
                    dataGridView1.Sort(nametechDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 3:
                    dataGridView1.Sort(priceDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 4:
                    dataGridView1.Sort(priceDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 5:
                    dataGridView1.Sort(sostoyDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 6:
                    dataGridView1.Sort(sostoyDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 7:
                    dataGridView1.Sort(lombadDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 8:
                    dataGridView1.Sort(lombadDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            var xlApp = new Excel.Application();
            xlApp.Visible = true;

            //Книга
            Microsoft.Office.Interop.Excel.Workbook wBook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;

            //Лист
            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)wBook.Sheets[1];
            //Присвоение имени листа
           // xlSheet.Name = "Техника";

            //Наименование каждого столбца
            xlSheet.Cells[1, 1] = "ID";
            xlSheet.Cells[1, 2] = "Название";
            xlSheet.Cells[1, 3] = "Цена";
            xlSheet.Cells[1, 4] = "Состояние товара";
            xlSheet.Cells[1, 5] = "Адрес ломбарда";

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
