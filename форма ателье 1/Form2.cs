using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace форма_ателье_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Data.b = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.e = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.i == true)
            {
                
                Form3 form3 = new Form3();
                form3.Show();
                Data.i = false; 
            
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.a= textBox1.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Data.c = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Data.d = textBox4.Text;
        }
    }
}
