using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Calculator : Form
    {
        private double Num = 0, Sum = 0, count = 0;
        private char temp, temp2, temp3;
        
        public Calculator()
        {
            InitializeComponent();
        }

        //按鈕轉數字字串
        private void Number_Click(object sender, EventArgs e)
        {           
            // 將 sender 轉換為按鈕
            Button clickBtn = sender as Button;
            if(display.Text == "0")
            {
                display.Text = clickBtn.Text;
            }
            else
            {
                display.Text += clickBtn.Text;
            }
            
        }

        //抓運算子
        private void Oper_Click(object sender, EventArgs e)
        {
            char lastchar = display.Text.Last();
            Button clickOper = sender as Button;
            temp = Convert.ToChar(clickOper.Text);
            count++;
            //判斷運算子前一個是否為數字，成立的話 持續抓數字
            if ((lastchar > 47 && lastchar < 58) && count!= 2)
            {
                display.Text += clickOper.Text;
            }
                       
            else if ((lastchar > 47 && lastchar < 58) && count ==2)
            {              
                object mySender = "="; // 這裡可以放任何你想要的 sender
                EventArgs myEventArgs = new EventArgs(); // 如果不需要額外參數，就這樣傳                
                Equal_Click(mySender, myEventArgs); // 手動觸發Equal_Click事件  
            }
            //更改運算子
            else
            {
                count--;
                display.Text = display.Text.Remove(display.Text.Length - 1);
                display.Text += clickOper.Text;             
            }
            temp2 = temp;
        }
        
        //抓數字和輸出運算結果
        private void Equal_Click(object sender, EventArgs e)
        {
            string displaytemp = display.Text;
            string[] parts;

            if (double.TryParse(display.Text, out double result)) // 如果是數字和= 的組合，則return
            {
                return; // 不執行後續程式
            }
            else
            {                
                //分割字串數字出來
                if (count == 2)
                {
                    parts = display.Text.Split(temp2);
                    temp3 = temp2;
                }
                else
                {
                    parts = display.Text.Split(temp);
                    temp3 = temp;
                }
                Sum = double.Parse(parts[0]);
                Num = double.Parse(parts[1]);

                switch (temp3)
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
                        Num = Double.Parse(display.Text);
                        break;
                }

                if (Num == 0 && temp == '/')
                {
                    this.display.Font = new System.Drawing.Font("新細明體", 15F);
                    display.Text = "無法除零，請按AC歸零";
                }
                else if (count == 2)
                {
                    count = 1;
                    display.Text = Convert.ToString(Sum) + temp;
                }
                else
                {
                    count = 0;
                    display.Text = Convert.ToString(Sum);
                }
                histext.Text += displaytemp + "=" + Sum + "\r\n";
            }
            
        }

        //清除歸零 AC
        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            histext.Text = "";
            Sum = 0;
            Num = 0;
            count = 0;
            temp2 = '\0';
            this.display.Font = new System.Drawing.Font("新細明體", 37F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

    }
}
