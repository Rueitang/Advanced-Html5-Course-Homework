using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketLibrary;

namespace MovieTicketSystem
{
    public partial class Form1 : Form
    {
        private MovieTicket ticket = new MovieTicket();

        public string text1, text2, text3;
        public string textBox2OldText;
        public int textBox2Number;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (int.TryParse(textBox2.Text, out textBox2Number))
                {
                    ticket.set_Price(textBox2Number);
                    switch (ticketKind.SelectedIndex)
                    {
                        case 0:
                            ticket.discount = new StudentDiscount();
                            ticket.price = ticket.discount.Calculate(ticket.get_Price());
                            break;

                        case 1:
                            ticket.discount = new ChildrenDiscount();
                            ticket.discount.TicketKind(childrenDiscount.SelectedIndex);
                            ticket.price = ticket.discount.Calculate(ticket.get_Price());
                            break;

                        case 2:
                            ticket.discount = new VIPDiscount();
                            if (vipDiscount.SelectedIndex == 0)
                                ticket.price = ticket.discount.Calculate(ticket.get_Price());
                            else
                                ticket.price = ticket.get_Price();

                            break;

                        default:
                            ticket.price = ticket.get_Price();
                            break;
                    }

                    ticket.set_Price(textBox2Number);
                    textBox1.Text = textBox2Number + "張" + ticketKind.Text + "原價" + ticket.get_Price() + "折扣後" + ticket.price;
                    //\\ + textBox2Number * 250;
                }
                else
                    textBox2.Text = textBox2OldText;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void studentDiscount_Enter(object sender, EventArgs e)
        {
            ticketKind.SelectedIndex = 0;
        }

        private void childrenDiscount_Enter(object sender, EventArgs e)
        {
            ticketKind.SelectedIndex = 1;
        }

        private void vipDiscount_Enter(object sender, EventArgs e)
        {
            ticketKind.SelectedIndex = 2;
        }

        public Form1()
        {
            InitializeComponent();

            textBox2OldText = textBox2.Text;

            text1 = studentDiscount.Text;
            text2 = childrenDiscount.Text;
            text3 = vipDiscount.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentDiscount.SelectedIndex = -1;
            childrenDiscount.SelectedIndex = -1;
            vipDiscount.SelectedIndex = -1;

            studentDiscount.Text = text1;
            childrenDiscount.Text = text2;
            vipDiscount.Text = text3;

            textBox2.Text = textBox2OldText;
        }
    }
}