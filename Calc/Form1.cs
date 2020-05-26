using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input.Text.Contains("+"))
            {
                string[] s = input.Text.Split('+');
                try
                {
                    double x = Convert.ToDouble(s[0]);
                    double y = Convert.ToDouble(s[1]);
                    double z = x + y;
                    input.Text = z.ToString();
                }
                catch
                {
                    input.Text = "возможно вместо запятой  вы использовали точку.";
                }
            }
            else if (input.Text.Contains("-"))
            {
                string[] s = input.Text.Split('-');
                try
                {
                double x = Convert.ToDouble(s[0]);
                double y = Convert.ToDouble(s[1]);
                double z = x - y;
                input.Text = z.ToString();
                }
                catch
                {
                    input.Text = "возможно вместо ','  вы использовали точку.";
                }
            }
            else if (input.Text.Contains("/"))
            {
                string[] s = input.Text.Split('/');
                try
                {
                    double x = Convert.ToDouble(s[0]);
                    double y = Convert.ToDouble(s[1]);
                    double z = x / y;
                    input.Text = z.ToString();
                }
                catch
                {
                    input.Text = "возможно вместо запятой  вы использовали точку.";
                }
            }
            else if (input.Text.Contains("*"))
            {
                string[] s = input.Text.Split('*');
                try
                {
                    double x = Convert.ToDouble(s[0]);
                    double y = Convert.ToDouble(s[1]);
                    double z = x * y;
                    input.Text = z.ToString();
                }
                catch
                {
                    input.Text = "возможно вместо запятой  вы использовали точку.";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + ',';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string a = input.Text;
            double s = Convert.ToDouble(a);
            double b = Math.Sqrt(s);
            string c = Convert.ToString(b);
            input.Text = c;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string value = input.Text;
            int s = input.Text.Length - 1;
            input.Text = value.Remove(s);
        }
    }
}
