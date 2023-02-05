using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanNet
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home homefrm = new Home();
            homefrm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Loginfrm loginfrm = new Loginfrm();
            loginfrm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            this.Hide();
            ord.Show();
        }
    }
}
