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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form36 p36 = new Form36();
            this.Hide();
            p36.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form37 p37 = new Form37();
            this.Hide();
            p37.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form38 p38 = new Form38();
            this.Hide();
            p38.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form39 p39 = new Form39();
            this.Hide();
            p39.ShowDialog();
            this.Show();

        }
    }
}
