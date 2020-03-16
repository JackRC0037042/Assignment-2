using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        private object label2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //set variables
            double resistance1;
            double resistance2;

            //Read resistance values
            try
            {
                resistance1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number fella");
                resistance1 = 0.0;
            }

            try
            {
                resistance2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("t y p e  a  n u m b e r");
                resistance2 = 0.0;
            }

            //Calculate totalresistance
            double totalresistance = resistance1 + resistance2;


            //put values for Fx and Fy in labels
            label1.Text = "resistance1 = " + resistance2 + " N";
            label2.Text = "resistance2 = " + resistance1 + " N";
        }

        private void R2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// double sin(double x)
        //{
          //  return (Math.Sin(x* Math.PI / 180.0));
       // }
