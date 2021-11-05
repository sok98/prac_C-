using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_struct
{
    public partial class Form1 : Form
    {
        struct stPlayer
        {
            public int cnt;

            public int picSun;
            public int picMoon;
            public int picStar;

            public int cardSum;

            public int CardSum(int sun, int moon, int star)
            {
                return sun + moon + star; 
            }

            public string resultText()
            {
                cnt++;
                cardSum = CardSum(picSun, picMoon, picStar);
                return string.Format("{0}회) 해 : {1}, 달 : {2}, 별 : {3} => 합계는 {4}",
                    cnt, picSun, picMoon, picStar, cardSum);
            }
        }

        stPlayer _p1;
        stPlayer _p2;

        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            int num = _rd.Next(1, 21);

            if (btnPlayer1.Checked)
                _p1.picSun = num;
            else
                _p2.picSun = num;

            result();
            CheckedChange();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            int num = _rd.Next(1, 21);

            if (btnPlayer1.Checked)
                _p1.picMoon = num;
            else
                _p2.picMoon = num;

            result();
            CheckedChange();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            int num = _rd.Next(1, 21);
            if (btnPlayer1.Checked)
                _p1.picStar = num;
            else
                _p2.picStar = num;

            result();
            CheckedChange();

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            if (btnPlayer1.Checked)
                _p1.cnt++;
            else
                _p2.cnt++;

            CheckedChange();
        }

        private void CheckedChange()
        {
            if (btnPlayer1.Checked)
                btnPlayer2.Checked = true;
            else if (btnPlayer2.Checked)
                btnPlayer1.Checked = true;
        }

        private void result()
        {
            if (btnPlayer1.Checked)
                lboxPlayer1.Items.Add(_p1.resultText());
            else
                lboxPlayer2.Items.Add(_p2.resultText());

            if (_p1.cnt >= 5 && _p2.cnt >= 5)
            {
                if (_p1.cardSum > _p2.cardSum)
                    MessageBox.Show("Player1이 이겼습니다.");
                else if (_p1.cardSum < _p2.cardSum)
                    MessageBox.Show("Player2가 이겼습니다.");
                else
                    MessageBox.Show("비겼습니다.");
            }
        }
    }
}
