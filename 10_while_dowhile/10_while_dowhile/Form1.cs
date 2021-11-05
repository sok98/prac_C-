using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_while_dowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int[] numArr = new int[6];
            int cnt = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // numArr가 다 안차면 계속 진행
            while (Array.IndexOf(numArr, 0) != -1)  // 값이 0인 인덱스가 없으면 -1 반환
            {
                int num = rd.Next(1, 46);   // 1부터 46까지

                if(Array.IndexOf(numArr, num) == -1)
                    numArr[cnt++] = num;
            }

            Array.Sort(numArr);
            foreach(var num in numArr)
                sb.Append(string.Format("{0},", num));

            lblResult.Text = sb.ToString();
            lboxResult.Items.Add(sb.ToString());
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(tboxSearchNum.Text);
            int rdNum = 0;
            int cnt = 0;

            if (inputNum < 1 || inputNum > 100)
            {
                MessageBox.Show("입력 오류입니다.");
                return;
            }

            Random rd = new Random();

            do
            {
                rdNum = rd.Next(1, 101);
                cnt++;
            }
            while (inputNum != rdNum);

            lblSearchResult.Text = string.Format("- 뽑은 숫자 {0}을 {1}회만에 찾았습니다.", inputNum, cnt);
        }
    }
}
