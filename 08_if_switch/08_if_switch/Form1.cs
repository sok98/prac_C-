using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(nNumber1.Text);
            int num2 = int.Parse(nNumber2.Text);

            if (num1 > num2)
                resultNum.Text = string.Format("{0}이 {1}보다 {2} 큽니다.", num1, num2, num1-num2);
            else if (num1 < num2)
                resultNum.Text = string.Format("{0}이 {1}보다 {2} 작습니다.", num1, num2, num2-num1);
            else
                resultNum.Text = string.Format("{0}과 {1}이 같습니다.", num1, num2);
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            string day = cboxDay.Text;
            string result = string.Empty;

            switch (day)
            {
                case "월":
                    result = "월요일 선택";
                    break;
                case "화":
                    result = "화요일 선택";
                    break;
                case "수":
                    result = "수요일 선택";
                    break;
                case "목":
                    result = "목요일 선택";
                    break;
                case "금":
                    result = "금요일 선택";
                    break;
                case "토":
                    result = "토요일 선택";
                    break;
                case "일":
                    result = "일요일 선택";
                    break;
                default:
                    result = "입력 오류";
                    break;
            }

            resultDay.Text = result;
        }
    }
}
