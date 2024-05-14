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
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Tequila sunrise.");
            if (radioButton5.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Paloma.");
            if (radioButton4.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Margarita.");
            if (radioButton3.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Tequila Sour.");
        }
    }
}
