using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_datatype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short num_short = short.Parse(inputNum.Text);
                lblShort.Text = num_short.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int num_int = int.Parse(inputNum.Text);
                lblInt.Text = num_int.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                int num_double = int.Parse(inputNum.Text);
                lblDouble.Text = num_double.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            short sNum = 0;
            int iNum = 0;
            double dNum = 0;

            if (short.TryParse(inputNum.Text, out sNum))
                lblShort.Text = sNum.ToString();
            if (int.TryParse(inputNum.Text, out iNum))
                lblInt.Text = iNum.ToString();
            if (double.TryParse(inputNum.Text, out dNum))
                lblDouble.Text = dNum.ToString();
        }
    }
}
