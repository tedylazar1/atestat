using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form30 p30 = new Form30();
            this.Hide();
            p30.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form31 p31 = new Form31();
            this.Hide();
            p31.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form32 p32 = new Form32();
            this.Hide();
            p32.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form34 p34 = new Form34();
            this.Hide();
            p34.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form33 p33 = new Form33();
            this.Hide();
            p33.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form35 p35 = new Form35();
            this.Hide();
            p35.ShowDialog();
            this.Show();
        }
    }
}
