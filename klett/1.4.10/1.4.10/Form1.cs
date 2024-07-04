using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double first,second;

        public void Print(object text)
        {
            label1.Text = text.ToString();
            label1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print(first / second);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(first + second);
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            second = double.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print(first - second);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Print(first * second);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Print(first % second);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {if(textBox1.Text!="")
            first = double.Parse(textBox1.Text);
        }
    }
}
