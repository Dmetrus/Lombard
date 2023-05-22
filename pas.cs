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
    public partial class pas : Form
    {
        string Login = "dima";
        string Password = "1488";
        public pas()
        {
            InitializeComponent();
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == Login && textBox2.Text == Password)
            {
                Main gyr = new Main();
                gyr.Owner = this;
                this.Hide();
                gyr.ShowDialog();
                this.Show();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
