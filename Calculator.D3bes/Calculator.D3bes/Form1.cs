using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.D3bes
{
    public partial class Form1 : Form
    {
        double sum1 = 0, sum2 = 0;string s;int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonsNumbers(object sender, EventArgs e)
        {
            textBox1.Text += ((Button) sender).Text;
        }
        private void ButtonsLog(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Contains("log"))
            {

                s = "log";
                sum1 = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            if (((Button)sender).Text.Contains("^"))
            {
                s = "^";
                sum1 = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            if (((Button)sender).Text.Contains("cos"))
            {
                s = "cos";
                sum1 = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            if (((Button)sender).Text.Contains("sin"))
            {
                s = "sin";
                sum1 = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
        }
        private void ButtonsOp(object sender, EventArgs e)
        {
            if(((Button)sender).Text.Contains("+"))
            {
                s = "+";
                sum1 +=double.Parse( textBox1.Text);
                textBox1.Text = null;
            }
            if (((Button)sender).Text.Contains("-"))
            {
                if(x==0)
                    sum1 += double.Parse(textBox1.Text);
               
               
              else  
                    sum1 -= double.Parse(textBox1.Text);
               
                
                textBox1.Text = null; s = "-";x++;
            }
            if (((Button)sender).Text.Contains("*"))
            {
                s = "*";
                sum1 = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            if (((Button)sender).Text.Contains("/"))
            {
                s = "/";
                sum1 = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            if (((Button)sender).Text.Contains("="))
            {
                if (s == "+")
                {
                    sum1 += double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(sum1);
                }
                if (s == "-")
                {
                    textBox1.Text = Convert.ToString(sum1 - double.Parse(textBox1.Text));

                }
                if (s == "/")
                {
                    textBox1.Text = Convert.ToString(sum1 / double.Parse(textBox1.Text));

                }
                if (s == "*")
                {
                    textBox1.Text = Convert.ToString(sum1 * double.Parse(textBox1.Text));

                }
                if(s=="^")
                {
                    textBox1.Text = Convert.ToString(Math.Pow(sum1,double.Parse(textBox1.Text)));
                }
                if (s == "log")
                {
                    textBox1.Text = Convert.ToString(Math.Log10(sum1));
                }
                if(s=="cos")
                {
                    textBox1.Text = Convert.ToString(Math.Cos(sum1));
                }
                if(s=="sin")
                {
                    textBox1.Text = Convert.ToString(Math.Sin(sum1));
                }
                sum1 = 0;s = null;
            }
            if (((Button)sender).Text.Contains("C"))
            {
                x = 0;
                textBox1.Text = null;
                sum1 = 0;
            }
        }
    }
}
