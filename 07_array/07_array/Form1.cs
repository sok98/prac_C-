using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayTest();
        }

        private void ArrayTest()
        {
            int[] arrTest1 = new int[5];
            arrTest1[0] = 5;

            int[] arrTest2 = new int[] { 3, 4, 5, 6 };

            int[] arrTest3 = { 1, 2, 3, 4 };

            int[,] arrTest4 = new int[2, 4] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 } };

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int len = arr.Length;
            Array.Clear(arr, 2, 3);             // arr의 2번째부터 2개 삭제
            Array.Resize(ref arr, 10);          // arr의 길이 10으로 변경. ref 잊지말기
            int search = Array.IndexOf(arr, 5); // arr의 값이 5인 인덱스 가져오기
        }

        private void week1_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            int[] arrDay = { 3, 6, 10, 11, 23, 14, 7 };
            dgDay["colDay1", 0].Value = arrDay[0];
            dgDay["colDay2", 0].Value = arrDay[1];
            dgDay["colDay3", 0].Value = arrDay[2];
            dgDay["colDay4", 0].Value = arrDay[3];
            dgDay["colDay5", 0].Value = arrDay[4];
            dgDay["colDay6", 0].Value = arrDay[5];
            dgDay["colDay7", 0].Value = arrDay[6];

            lblTotal.Text = string.Format("전체 자료 수 : {0}", arrDay.Length);
        }

        private void week2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            dgDay.Rows.Add();

            int[,] arrDay = { { 3, 6, 10, 11, 23, 14, 7 }, { 5, 3, 9, 11, 26, 11, 4 } };

            dgDay["colDay1", 0].Value = arrDay[0, 0];
            dgDay["colDay2", 0].Value = arrDay[0, 1];
            dgDay["colDay3", 0].Value = arrDay[0, 2];
            dgDay["colDay4", 0].Value = arrDay[0, 3];
            dgDay["colDay5", 0].Value = arrDay[0, 4];
            dgDay["colDay6", 0].Value = arrDay[0, 5];
            dgDay["colDay7", 0].Value = arrDay[0, 6];

            dgDay["colDay1", 1].Value = arrDay[1, 0];
            dgDay["colDay2", 1].Value = arrDay[1, 1];
            dgDay["colDay3", 1].Value = arrDay[1, 2];
            dgDay["colDay4", 1].Value = arrDay[1, 3];
            dgDay["colDay5", 1].Value = arrDay[1, 4];
            dgDay["colDay6", 1].Value = arrDay[1, 5];
            dgDay["colDay7", 1].Value = arrDay[1, 6];

            lblTotal.Text = string.Format("전체 자료 수 : {0}", arrDay.Length);
        }
    }
}
