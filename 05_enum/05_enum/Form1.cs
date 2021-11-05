using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thusday,
            Friday,
            Saturday,
            Sunday
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday);
            lboxDay.Items.Add(enumDay.Tuesday);
            lboxDay.Items.Add(enumDay.Wednesday);
            lboxDay.Items.Add(enumDay.Thusday);
            lboxDay.Items.Add(enumDay.Friday);
            lboxDay.Items.Add(enumDay.Saturday);
            lboxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);
        }

        // 00와 0요일 00에 보기로 했습니다.
        private void btnResult_Click(object sender, EventArgs e)
        {
            tboxResult.Text = tboxName.Text + "와 " + lboxDay.SelectedItem + "(요일) " 
                + lboxTime.SelectedItem + "에 보기로 했습니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tboxResult.Text = resultText(tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
        }

        /// <summary>
        /// 함수에 대한 주석을 다는 공간입니다.
        /// ///로 표현합니다.
        /// "00와 0(요일) 00에 보기로 했습니다."의 형태로 반환합니다.
        /// </summary>
        /// <param name="name">이름</param>
        /// <param name="day">요일</param>
        /// <param name="time">시간</param>
        /// <returns>"00와 0(요일) 00에 보기로 했습니다."</returns>
        private string resultText(string name, string day, string time)
        {
            string result = string.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.", name, day, time);
            return result;
        }
    }
}
