using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        String num;
        Double num1;
        Double num2;
        bool mul = false;
        bool add = false;
        bool sub = false;
        bool div = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = num + ".";
            textBox1.Text = num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = num + "0";
            textBox1.Text = num;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num);
            if(add == true)
            {
                num1 = num1 + num2;
                textBox1.Text = Convert.ToString(num1);
                num = "";
                num1 = 0;
                num2 = 0;
            }
            else if (sub == true)
            {
                num1 = num1 - num2;
                textBox1.Text = Convert.ToString(num1);
                num = "";
                num1 = 0;
                num2 = 0;
            }
            else if (mul == true)
            {
                num1 = num1 * num2;
                textBox1.Text = Convert.ToString(num1);
                num = "";
                num1 = 0;
                num2 = 0;
            }
            else if (div == true)
            {
                num1 = num1 / num2;
                textBox1.Text = Convert.ToString(num1);
                num = "";
                num1 = 0;
                num2 = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            add = false;
            sub = false;
            div = false;
            mul = true;
            num2 = Convert.ToDouble(num);
            num = "";
            textBox1.Text = num;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num = num + "1";
            textBox1.Text = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = num + "2";
            textBox1.Text = num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = num + "3";
            textBox1.Text = num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = num + "4";
            textBox1.Text = num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = num + "5";
            textBox1.Text = num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = num + "6";
            textBox1.Text = num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = num + "7";
            textBox1.Text = num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = num + "8";
            textBox1.Text = num;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = num + "9";
            textBox1.Text = num;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add = true;
            sub = false;
            div = false;
            mul = false;
            num2 = Convert.ToDouble(num);
            num = "";
            textBox1.Text = num;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            add = false;
            sub = true;
            div = false;
            mul = false;
            num2 = Convert.ToDouble(num);
            num = "";
            textBox1.Text = num;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            add = false;
            sub = false;
            div = true;
            mul = false;
            num2 = Convert.ToDouble(num);
            num = "";
            textBox1.Text = num;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = "";
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
            add = false;
            sub = false;
            div = false;
            mul = false;
        }
    }
}
