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
    public partial class Form45 : Form
    {
        public Form45()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Hugo.");
            if (radioButton5.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Mimosa.");
            if (radioButton4.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Rossini.");
            if (radioButton3.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Aperol Spritz.");
        }
    }
}
