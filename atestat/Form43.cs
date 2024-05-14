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
    public partial class Form43 : Form
    {
        public Form43()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Gin tonic.");
            if (radioButton5.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Long Island.");
            if (radioButton4.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Martini.");
            if (radioButton3.Checked)
                MessageBox.Show("Cocktail-ul ideal pentru tine este Negroni.");
        }
    }
}
