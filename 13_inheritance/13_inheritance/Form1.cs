using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_inheritance
{
    public partial class Form1 : Form
    {
        COneCycle c1;
        CCycle c2;
        CCar c3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1 = new COneCycle("외발 자전거");
            c2 = new CCycle("자전거");
            c3 = new CCar("자동차");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Q)
            {
                fMoveing(-5);
            }else if (e.KeyCode == Keys.W)
            {
                fMoveing(5);
            }
        }


        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            OneCycleDraw();
        }
        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            CCycleDraw();
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            CCarDraw();
        }

        /// <summary>
        /// panel을 초기화한다.
        /// </summary>
        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }

        /// <summary>
        /// OneCycle에 대한 위치 그림을 그려준다.
        /// </summary>
        private void OneCycleDraw()
        {
            lblName.Text = c1.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = c1.penInfo();

            g.DrawRectangle(p, c1._rtSquare1);
            g.DrawEllipse(p, c1._rtCircle1);
        }

        /// <summary>
        /// CCycle에 대한 위치 그림을 그려준다.
        /// </summary>
        private void CCycleDraw()
        {
            lblName.Text = c2.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = c2.penInfo();

            g.DrawRectangle(p, c2._rtSquare1);
            g.DrawEllipse(p, c2._rtCircle1);
            g.DrawEllipse(p, c2._rtCircle2);
        }

        /// <summary>
        /// CCar에 대한 위치 그림을 그려준다.
        /// </summary>
        private void CCarDraw()
        {
            lblName.Text = c3.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = c3.penInfo();

            g.DrawRectangle(p, c3._rtSquare1);
            g.DrawRectangle(p, c3._rtSquare2);
            g.DrawEllipse(p, c3._rtCircle1);
            g.DrawEllipse(p, c3._rtCircle2);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fMoveing(-5);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            fMoveing(5);
        }

        private void fMoveing(int s)
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    c1.fMove(s);
                    OneCycleDraw();
                    break;
                case "자전거":
                    c2.fMove(s);
                    CCycleDraw();
                    break;
                case "자동차":
                    c3.fMove(s);
                    CCarDraw();
                    break;
            }
        }
    }
}
