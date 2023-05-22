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

namespace Lombard
{
    public partial class jew : Form
    {

        string dostup;
        public jew()
        {
            InitializeComponent();           
        }

        public void Dost(string user)
        {
            dostup = user;
        }

        private void jew_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.Jew". При необходимости она может быть перемещена или удалена.
            this.jewTableAdapter.Fill(this.databaselomDataSet.Jew);
            combosos.SelectedIndex = 0;
            comboad.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            if (dostup == "Пользователь")
            {
                panel1.Enabled = false;
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

            
            bool usl = namez.Text.Length > 0 && rice.Text.Length > 0 && prob.Text.Length > 0;
            if (usl)
            {
                if (this != null)
                {
                    DataRow nRow = databaselomDataSet.Tables[0].NewRow();
                    nRow[0] = 0;
                    nRow[1] = namez.Text;
                    nRow[2] = rice.Text;
                    nRow[3] = combosos.Text;
                    nRow[4] = prob.Text;
                    nRow[5] = comboad.Text;

                    databaselomDataSet.Tables[0].Rows.Add(nRow);
                    jewTableAdapter.Update(databaselomDataSet.Jew);
                    databaselomDataSet.Tables[0].AcceptChanges();
                    jew_Load(sender, e);

                    namez.Text = "";
                    rice.Text = "";
                    prob.Text = "";
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
                        SqlCommand command = new SqlCommand("DELETE FROM [Jew] WHERE ID_Jew = @pID", connection);
                        command.Parameters.Add(new SqlParameter("@pID", this.dataGridView1.CurrentRow.Cells["ID_Jew"].Value));
                        command.ExecuteNonQuery();
                        jew_Load(sender, e);
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
            jewBindingSource.Filter = "[Name_Tov] LIKE'" + textBox1.Text + "%'";
            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Товара с данным именем отсутствует","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.Sort(ID_Jew, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 1:
                    dataGridView1.Sort(nameTovDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 2:
                    dataGridView1.Sort(nameTovDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 3:
                    dataGridView1.Sort(priceDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 4:
                    dataGridView1.Sort(priceDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 5:
                    dataGridView1.Sort(sostDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 6:
                    dataGridView1.Sort(sostDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 7:
                    dataGridView1.Sort(probaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 8:
                    dataGridView1.Sort(probaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case 9:
                    dataGridView1.Sort(lombadDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case 10:
                    dataGridView1.Sort(lombadDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
                    break;
            }
        }
    }
}
