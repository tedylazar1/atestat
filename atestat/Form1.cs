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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 p2 = new Form2();
            this.Hide();
            p2.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 p3 = new Form3();
            this.Hide();
            p3.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 p4 = new Form4();
            this.Hide();
            p4.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 p5 = new Form5();
            this.Hide();
            p5.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form40 p40 = new Form40();
            this.Hide();
            p40.ShowDialog();
            this.Show();
        }
    }
}
