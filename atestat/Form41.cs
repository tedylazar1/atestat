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
    public partial class Form41 : Form
    {
        public Form41()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Pina Colada.");
            if (radioButton5.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Negroni.");
            if (radioButton4.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Cuba Libre.");
            if (radioButton3.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Pina Colada extra.");

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
