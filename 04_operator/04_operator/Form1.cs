using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tboxNum1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tboxBit.Text = Convert.ToString(int.Parse(tboxNum1.Text), 2);
            }
            catch
            {
                tboxBit.Text = "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = int.Parse(tboxNum1.Text) << int.Parse(tboxNum2.Text);
            tboxNum1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = int.Parse(tboxNum1.Text) >> int.Parse(tboxNum2.Text);
            tboxNum1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tboxNum1.Text);
            int num2 = int.Parse(tboxNum2.Text);

            num1 += num2;
            tboxNum1.Text = num1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tboxNum1.Text);
            int num2 = int.Parse(tboxNum2.Text);

            num1 -= num2;
            tboxNum1.Text = num1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tboxNum1.Text);
            tboxNum1.Text = (++num).ToString();
            tboxAfter.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tboxNum1.Text);
            tboxNum1.Text = (num++).ToString();
            tboxAfter.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tboxNum1.Text);
            int num2 = int.Parse(tboxAfter.Text);
            int tmp = int.Parse(tboxNum2.Text);

            bool result = num1 > tmp && num2 > tmp;
            tboxBool.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tboxNum1.Text);
            int num2 = int.Parse(tboxAfter.Text);
            int tmp = int.Parse(tboxNum2.Text);

            bool result = num1 > tmp || num2 > tmp;
            tboxBool.Text = result.ToString();
        }
    }
}
