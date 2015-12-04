using HomeWorkLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_andB
{
    public partial class Form1 : Form
    {
        private int[] getData = new int[4];
        private int[] keyData = new int[4];
        private char[] labelText = { '0', 'A', '0', 'B' };
        public string sumData = "輸入數字，" + "\t提示";
        private GetRecord recode = new GetRecord();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string text1 = "";
            for (int time1 = 0; time1 < getData.Length; time1++)
                text1 = text1 + getData[time1].ToString();
            this.label1.Text = text1;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            getData = recode.GetNumber();
            string text1 = "";
            this.textBox2.Text = "";
            for (int time1 = 0; time1 < labelText.LongLength; time1++)
                text1 = text1 + labelText[time1];
            this.label1.Text = text1;
            this.textBox1.Enabled = false;
            keyIn akeyIn = new keyIn();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn7.Text;
            akeyIn.showText = textBox1.Text;
            if (btn7.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn7.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn8.Text;
            akeyIn.showText = textBox1.Text;
            if (btn8.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn8.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn9.Text;
            akeyIn.showText = textBox1.Text;
            if (btn9.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn9.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn6.Text;
            akeyIn.showText = textBox1.Text;
            if (btn6.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn6.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn5.Text;
            akeyIn.showText = textBox1.Text;
            if (btn5.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn5.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn4.Text;
            akeyIn.showText = textBox1.Text;
            if (btn4.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn4.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn3.Text;
            akeyIn.showText = textBox1.Text;
            if (btn3.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn3.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn2.Text;
            akeyIn.showText = textBox1.Text;
            if (btn2.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn2.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn1.Text;
            akeyIn.showText = textBox1.Text;
            if (btn1.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn1.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btnent_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 4)
            {
                int aNumber = 0;
                int bNumber = 0;
                string char1 = "";
                char[] charArray = new char[4];
                charArray = textBox1.Text.ToArray();
                for (int time1 = 0; time1 < keyData.Length; time1++)
                {
                    char1 = charArray[time1].ToString();
                    keyData[time1] = int.Parse(char1);
                    if (keyData[time1] == getData[time1])
                        aNumber++;
                    for (int time2 = 0; time2 < getData.Length; time2++)
                        if (keyData[time1] == getData[time2])
                            bNumber++;
                }
                char1 = "";
                bNumber = bNumber - aNumber;

                for (int time1 = 0; time1 < labelText.Length; time1++)
                {
                    if (time1 == 0)
                        char1 = aNumber.ToString();
                    if (time1 == 1)
                        char1 = char1 + "A";
                    if (time1 == 2)
                        char1 = char1 + bNumber.ToString();
                    if (time1 == 3)
                        char1 = char1 + "B";
                }
                this.label1.Text = char1;
                sumData = sumData + textBox1.Text + ",\t\t" + char1 + "\r\n";
                this.textBox2.Text = sumData + "";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            keyIn akeyIn = new keyIn();
            akeyIn.keyText = btn0.Text;
            akeyIn.showText = textBox1.Text;
            if (btn0.BackColor != Color.Red)
                if (akeyIn.addText())
                {
                    btn0.BackColor = Color.Red;
                    textBox1.Text = akeyIn.showText;
                }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            btn0.BackColor = SystemColors.Control;
            btn1.BackColor = SystemColors.Control;
            btn2.BackColor = SystemColors.Control;
            btn3.BackColor = SystemColors.Control;
            btn4.BackColor = SystemColors.Control;
            btn5.BackColor = SystemColors.Control;
            btn6.BackColor = SystemColors.Control;
            btn7.BackColor = SystemColors.Control;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}