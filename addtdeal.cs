using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lombard
{
    public partial class addtdeal : Form
    {
        public addtdeal()
        {
            InitializeComponent();
        }

        private void addtdeal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.Tech". При необходимости она может быть перемещена или удалена.
            this.techTableAdapter.Fill(this.databaselomDataSet.Tech);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.databaselomDataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main may = this.Owner as Main;
            if (may != null)
            {
                DataRow nRow = may.databaselomDataSet.Tables[4].NewRow();
                nRow[0] = 0;
                nRow[1] = comboBox2.SelectedValue;

                nRow[2] = comboBox1.SelectedValue;

                nRow[3] = label6.Text;

                may.databaselomDataSet.Tables[4].Rows.Add(nRow);
                may.techdealTableAdapter.Update(may.databaselomDataSet.Techdeal);
                may.databaselomDataSet.Tables[4].AcceptChanges();
                may.Main_Load(sender, e);


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indi = comboBox2.SelectedIndex;
            comboBox3.SelectedIndex = indi;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;
            comboBox4.SelectedIndex = ind;
        }
    }
}
