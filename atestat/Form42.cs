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
    public partial class Form42 : Form
    {
        public Form42()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Bubble Gum.");
            if (radioButton5.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Cosmopolitan.");
            if (radioButton4.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Green apple vodka.");
            if (radioButton3.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Sex on the beach.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
