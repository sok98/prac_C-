using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            // lblMain 텍스트 불러오기
            string txt = lblMain.Text;
            
            // txt에 Text 있는지 확인 후 bool 반환
            txtContain.Text = txt.Contains("Text").ToString();
            
            // txt가 Text와 같은지 확인 후 bool 반환
            txtEquals.Text = txt.Equals("Text").ToString();
            
            // txt의 길이 반환
            txtLength.Text = txt.Length.ToString();
            
            // Text를 tttt로 변경
            txtReplace.Text = txt.Replace("Text", "tttt");
            
            // txt를 공백 기준으로 쪼갬
            string[] txtSplit = txt.Split();
            txtSplit1.Text = txtSplit[0];
            txtSplit2.Text = txtSplit[1];
            txtSplit3.Text = txtSplit[2];
            
            // txt의 3번째부터 5글자 반환
            txtSubstring.Text = txt.Substring(3, 5);

            // txt 소문자
            txtToLower.Text = txt.ToLower();

            // txt 대문자
            txtToUpper.Text = txt.ToUpper();

            // txt 전후 공백 제거
            txtTrim.Text = txt.Trim();

        }
    }
}
