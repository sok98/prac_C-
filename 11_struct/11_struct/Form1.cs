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
        //struct stPlayer
        //{
        //    public int cnt;

        //    public int picSun;
        //    public int picMoon;
        //    public int picStar;

        //    public int cardSum;

        //    public int CardSum(int sun, int moon, int star)
        //    {
        //        return sun + moon + star; 
        //    }

        //    public string resultText()
        //    {
        //        cnt++;
        //        cardSum = CardSum(picSun, picMoon, picStar);
        //        return string.Format("{0}회) 해 : {1}, 달 : {2}, 별 : {3} => 합계는 {4}",
        //            cnt, picSun, picMoon, picStar, cardSum);
        //    }
        //}

        struct stPlayer
        {
            public int cnt;

            public int picSun;
            public int picMoon;
            public int picStar;

            public int cardSum;
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

        CPlayer _cp = new CPlayer();

        private void result()
        {
            if (btnPlayer1.Checked)
            {
                _p1.cnt++;
                _p1.cardSum = _cp.CardSum(_p1.picSun, _p1.picMoon, _p1.picStar);
                lboxPlayer1.Items.Add(_cp.resultText(_p1.cnt, _p1.picSun, _p1.picMoon, _p1.picStar, _p1.cardSum));
            }
            else
            {
                _p2.cnt++;
                _p2.cardSum = _cp.CardSum(_p2.picSun, _p2.picMoon, _p2.picStar);
                lboxPlayer2.Items.Add(_cp.resultText(_p2.cnt, _p2.picSun, _p2.picMoon, _p2.picStar, _p2.cardSum));
            }

            if (_p1.cnt == _p2.cnt)
            {
                lboxNow.Items.Add(_cp.PlayerPair(_p1.cnt, _p1.cardSum, _p2.cardSum));

                if (_p1.cnt >= 5)
                {
                    lboxNow.Items.Add(_cp.PlayerResult(_p1.cardSum, _p2.cardSum));
                }
            }
        }
    }
}
