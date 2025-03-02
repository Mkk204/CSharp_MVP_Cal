using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator_factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            display.Text = "";
        }

        private double Num = 0, Sum = 0, count = 0;
        private char Opertemp;
        
        private void Numbtn_Click(object sender, EventArgs e)
        {
            Button Numbtn = sender as Button;
            display.Text += Numbtn.Text;            
        }

        private void Operbtn_Click(object sender, EventArgs e)
        {
            Button Operbtn = sender as Button;
            Opertemp = Convert.ToChar(Operbtn.Text);
            display.Text += Operbtn.Text;          
        }


        private void Equalbtn_Click(object sender, EventArgs e)
        {
            string NumB = display.Text;
            string[] parts = NumB.Split(Opertemp);
            
            var oper = OperationFactory.CreateOperation(Opertemp);
            oper.NumberA = double.Parse(parts[0]);
            oper.NumberB = double.Parse(parts[1]);
            display.Text += "=" + oper.GetResult();         
        }
    }
}
