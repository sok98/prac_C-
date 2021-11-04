using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] fInput()
        {
            int[] num = new int[2];

            num[0] = int.Parse(inputNum1.Text);
            num[1] = int.Parse(inputNum2.Text);

            return num;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int[] num = fInput();

            int result = num[0] + num[1];
            resultBox.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int[] num = fInput();

            int result = num[0] - num[1];
            resultBox.Text = result.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int[] num = fInput();

            int result = num[0] * num[1];
            resultBox.Text = result.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int[] num = fInput();

            try
            {
                int result1 = num[0] / num[1];
                int result2 = num[0] % num[1];
                resultBox.Text = result1.ToString() + "-" + result2.ToString();
            }
            catch(Exception)
            {
                resultBox.Text = "Error";
            }
        }
    }
}
