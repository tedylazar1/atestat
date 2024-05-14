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
    public partial class Form40 : Form
    {
        public Form40()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                Form41 p41 = new Form41();
                this.Hide();
                p41.ShowDialog();
                this.Show();
            }
            if (radioButton17.Checked)
            {
                Form42 p42 = new Form42();
                this.Hide();
                p42.ShowDialog();
                this.Show();
            }
            if (radioButton16.Checked)
            {
                Form43 p43 = new Form43();
                this.Hide();
                p43.ShowDialog();
                this.Show();
            }
            if (radioButton15.Checked)
            {
                Form44 p44 = new Form44();
                this.Hide();
                p44.ShowDialog();
                this.Show();
            }
            if (radioButton1.Checked)
            {
                Form45 p45 = new Form45();
                this.Hide();
                p45.ShowDialog();
                this.Show();
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
