using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn1.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn1.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;

            if (again)
            {
                this.textBox1.Text = this.btn2.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn2.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn3.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn3.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn4.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn4.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn5.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn5.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;

            if (again)
            {
                this.textBox1.Text = this.btn6.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn6.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn7.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn7.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;

            if (again)
            {
                this.textBox1.Text = this.btn8.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn8.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn9.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn9.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btn0.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btn0.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void buttonPot_Click(object sender, EventArgs e)
        {
            double floatIn;
            string strIn;
            if (again)
            {
                this.textBox1.Text = this.btnPot.Text;
                again = false;
                keyin = true;
            }
            else
            {
                strIn = this.textBox1.Text + this.btnPot.Text;
                floatIn = double.Parse(strIn);
                this.textBox1.Text = floatIn.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            charOp = '+';
            if (number1 == 0)
            {
                number1 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "0";
            }
            else if (keyin)
            {
                sum = number1 + double.Parse(this.textBox1.Text);
                number1 = sum;
                this.textBox1.Text = sum.ToString();
                again = true;
                keyin = false;
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            charOp = '-';
            if (number1 == 0)
            {
                number1 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "0";
            }
            else if (keyin)
            {
                sum = number1 - double.Parse(this.textBox1.Text);
                number1 = sum;
                this.textBox1.Text = sum.ToString();
                again = true;
                keyin = false;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            charOp = '/';
            if (number1 == 0)
            {
                number1 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "0";
            }
            else if (keyin)
            {
                sum = number1 / double.Parse(this.textBox1.Text);
                number1 = sum;
                this.textBox1.Text = sum.ToString();
                again = true;
                keyin = false;
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            charOp = '*';
            if (number1 == 0)
            {
                number1 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "0";
            }
            else if (keyin)
            {
                sum = number1 * double.Parse(this.textBox1.Text);
                number1 = sum;
                this.textBox1.Text = sum.ToString();
                again = true;
                keyin = false;
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            char OP = charOp;

            switch (OP)
            {
                case '+':
                    sum = number1 + double.Parse(this.textBox1.Text);
                    this.textBox1.Text = sum.ToString();
                    charOp = '=';
                    break;

                case '-':
                    sum = number1 - double.Parse(this.textBox1.Text);
                    this.textBox1.Text = sum.ToString();
                    charOp = '=';
                    break;

                case '*':
                    sum = number1 * double.Parse(this.textBox1.Text);
                    this.textBox1.Text = sum.ToString();
                    charOp = '=';
                    break;

                case '/':
                    sum = number1 / double.Parse(this.textBox1.Text);
                    this.textBox1.Text = sum.ToString();
                    charOp = '=';
                    break;

                case '=':
                    this.textBox1.Text = "0";
                    number1 = 0;
                    sum = 0;

                    break;

                default:
                    charOp = '=';

                    break;
            }
            again = false;
            keyin = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
        }

        public char charOp = '=';
        public double number1 = 0;
        public double number2 = 0;
        public double sum = 0;
        public bool again = false;
        public bool keyin = false;
    }
}