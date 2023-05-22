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
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main ggr = new Main();
            ggr.Owner = this;
            this.Hide();
            ggr.Dost("Пользователь");
            ggr.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pas dlc = new pas();
            this.Hide();
            dlc.ShowDialog();
            this.Show();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
