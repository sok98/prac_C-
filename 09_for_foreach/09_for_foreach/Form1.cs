using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_for_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            txtBox.Text = string.Empty;
            StringBuilder sb = new StringBuilder();

            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result += i;
                sb.Append(string.Format("1에서 {0}까지 더하면 {1} \r\n", i, result));
            }

            txtBox.Text = sb.ToString();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            txtBox.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            string[] strArr = { "a", "b", "c", "d", "e", "f", "g" };

            int i = 1;
            foreach ( var name in strArr)
            {
                sb.Append(string.Format("{0} : {1}반 \r\n", name, i++));
            }

            txtBox.Text = sb.ToString();
        }
    }
}
