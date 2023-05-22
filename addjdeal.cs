using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lombard
{
    public partial class addjdeal : Form
    {
        public addjdeal()
        {
            InitializeComponent();
        }

        private void addjdeal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.databaselomDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaselomDataSet.Jew". При необходимости она может быть перемещена или удалена.
            this.jewTableAdapter.Fill(this.databaselomDataSet.Jew);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Main man = this.Owner as Main;
            if (man != null)
            {
                DataRow nRow = man.databaselomDataSet.Tables[1].NewRow();
                nRow[0] = 0;
                nRow[1] = comboBox2.SelectedValue;
                
                nRow[2] = comboBox1.SelectedValue;
               
                nRow[3] = label6.Text;

                man.databaselomDataSet.Tables[1].Rows.Add(nRow);
                man.jewdealTableAdapter.Update(man.databaselomDataSet.Jewdeal);
                man.databaselomDataSet.Tables[1].AcceptChanges();
                man.Main_Load(sender, e);

                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            comboBox3.SelectedIndex = index;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;
            comboBox4.SelectedIndex = ind;
        }
    }
}
