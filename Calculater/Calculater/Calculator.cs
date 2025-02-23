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
        private int Num = 0, Sum = 0;
        private char temp;

        public Calculator()
        {
            InitializeComponent();
        }

        //按鈕轉數字字串
        private void Number_Click(object sender, EventArgs e)
        {           
            // 將 sender 轉換為按鈕
            Button clickBtn = sender as Button;
            display.Text += clickBtn.Text;
        }

        //抓運算子
        private void Oper_Click(object sender, EventArgs e)
        {
            Button clickOper = sender as Button;           
            display.Text += clickOper.Text;
            temp = Convert.ToChar(clickOper.Text);
        }

        //抓數字和輸出運算結果
        private void Sum_Click(object sender, EventArgs e)
        {
            //分割字串數字出來
            string[] parts = display.Text.Split(temp);
            Sum = int.Parse(parts[0]);
            Num = int.Parse(parts[1]);

            switch (temp)
            {
                case '+':
                    Sum += Num;
                    break;
                case '-':
                    Sum -= Num;
                    break;
                case '*':
                    Sum *= Num;
                    break;
                case '/':
                    Sum /= Num;
                    break;
                case '%':
                    Sum %= Num;
                    break;
                default:
                    Num = Int32.Parse(display.Text);
                    break;
            }
            display.Text = Convert.ToString(Sum);
        }

        //清除 AC
        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "";
            Sum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
