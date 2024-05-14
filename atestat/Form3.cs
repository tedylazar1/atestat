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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form27 p27 = new Form27();
            this.Hide();
            p27.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form21 p21 = new Form21();
            this.Hide();
            p21.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form26 p26 = new Form26();
            this.Hide();
            p26.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form29 p29 = new Form29();
            this.Hide();
            p29.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form28 p28 = new Form28();
            this.Hide();
            p28.ShowDialog();
            this.Show();
        }
    }
}
