using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static int Val => 30;
        public static int count = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (user == "Umar" && pass == "1234")
            {
                MessageBox.Show("Hello " + user, "Verification Success");
            }
            else
            {
                if (user == "" && pass == "")
                {
                    MessageBox.Show("Invalid Credentails\nPlease contact Administrator!", "Verification Failed");
                }
                else
                {
                    MessageBox.Show("Hello " + user+"\nYou are not a real user sorry\ntry Umar and 1234", "Verification Failed");
                }
            }
            label2.Text="";
            label2.Text = "THANK YOU FOR USING OUR FORM,HAVE A GREAT DAY!\nREGARDS :UMAR AHMED";
            progressBar1.Value += Val;
            button1.Hide();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (progressBar1.Value != 70)
            {
                progressBar1.Value += Val;
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (progressBar1.Value != 70)
            {
                progressBar1.Value += Val;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string conv;
            conv = count.ToString();
            int countmin;
            int counthour;
            if (count <= 60)
            {
                label4.Text = "Time Elapsed : " + conv+" Seconds";
            }
            else
            {
                if (count / 60 <= 60)
                {
                    countmin = count / 60;
                    conv = countmin.ToString();
                    label4.Text = "Time Elapsed : " + conv + " Minutes";
                }
                else
                {
                    if (count / 3600 <= 60)
                    {
                        counthour = count / 60;
                        conv = counthour.ToString();
                        label4.Text = "Time Elapsed : " + conv + " Hours";
                    }
                }
            }

            count++;
            //Console.WriteLine("ok");
        }
    }
}
