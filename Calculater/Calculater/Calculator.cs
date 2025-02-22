using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Calculator : Form
    {
        private int NumA = 0, NumB = 0, Sum = 0;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumA = 1;
            display.Text += "1";
            //Button btn = sender as Button;
            //display.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumB = 2;
            display.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //運算子 +
        private void button13_Click(object sender, EventArgs e)
        {
            display.Text += "+";           
        }

        //清除 AC
        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //運算符 =
        private void button12_Click(object sender, EventArgs e)
        {
            if(Sum==0) Sum = NumA + NumB;
            else       Sum = Sum + NumA;

            display.Text = Convert.ToString(Sum);
        }
    }
}
