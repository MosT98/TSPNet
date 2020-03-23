using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorStiintific
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Equals("0"))
            {
                textBox.Text += "0";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void bpunct_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void binmultire_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void bimpartire_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void begal_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            double result = 0;
            //double[] numbers;
            char[] ops = { '+', '-', '/', '*' };
            List<double> numbers = new List<double>();
            char op = 'a';
            foreach (var ch in text)
            {
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    op = ch;
                    string[] nrs = text.Split(ch);
                    
                    foreach (var nr in nrs)
                    {
                        numbers.Add(double.Parse(nr));
                    }
                }
            }

            if (op == '+')
            {
                result = numbers[0] + numbers[1];
            }
            else if(op == '-')
            {
                result = numbers[0] - numbers[1];
            }
            else if (op == '*')
            {
                result = numbers[0] * numbers[1];
            }
            else if (op == '/')
            {
                result = numbers[0] / numbers[1];
            }

            textBox.Text = result.ToString();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
    }
}
