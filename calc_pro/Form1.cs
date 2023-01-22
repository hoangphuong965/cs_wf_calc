using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        double result = 0;
        bool temp = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkZero()
        {
            if (this.main_num_label1.Text == "0")
            {
                this.main_num_label1.Text = "";
            }
        }

        private void checkOpera()
        {
            this.first_num_label.Text = this.main_num_label1.Text;
            if (this.first_num_label.Text != string.Empty)
            {
                this.main_num_label1.Text = "";
            }

        }

        private void checkResult(string number)
        {
            if (temp)
            {
                this.main_num_label1.Text = "";
            }
            temp = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = "0";
            this.first_num_label.ResetText();
            this.opera_label.ResetText();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkZero();
            this.main_num_label1.Text = this.main_num_label1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkZero();
            string number = "1";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text+ number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkZero();
            string number = "2";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text+ number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkZero();
            string number = "3";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkZero();
            string number = "4";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            checkZero();
            string number = "5";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            checkZero();
            string number = "6";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            checkZero();
            string number = "7";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            checkZero();
            string number = "8";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            checkZero();
            string number = "9";
            checkResult(number);
            this.main_num_label1.Text = this.main_num_label1.Text + number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.opera_label.Text = "+";
            checkOpera();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.opera_label.Text = "-";
            checkOpera();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.opera_label.Text = "x";
            checkOpera();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.opera_label.Text = "/";
            checkOpera();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(first_num_label.Text != "" && main_num_label1.Text != "")
            {
                double fn;
                double sn;
                double.TryParse(first_num_label.Text, out fn);
                double.TryParse(main_num_label1.Text, out sn);
                switch (this.opera_label.Text)
                {
                    case "+":
                        result = fn + sn;
                        break;
                    case "-":
                        result = fn - sn;
                        break;
                    case "x":
                        result = fn * sn;
                        break;
                    case "/":
                        result = fn / sn;
                        break;
                    default:
                        //throw new NotImplementedException("error");
                        break;
                }
                this.main_num_label1.Text = result.ToString();
                this.temp = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + ".";
        }
    }
}
