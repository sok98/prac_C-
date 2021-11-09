using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Timer
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        XMLControl _xml = new XMLControl();
        string strPath = Application.StartupPath + "\\save.xml";

        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 0;
        private int i1Level = 0;

        private int i3Add = 0;
        private int i3Level = 0;

        private int i50Add = 0;
        private int i50Level = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(strPath))
            {
                // File이 있을 경우 File Loading
                _dData = _xml.fXML_Reader(strPath);

                iTick = double.Parse(_dData[XMLControl._TICK]);
                iTotal = double.Parse(_dData[XMLControl._TOTAL]);
                i1Level = int.Parse(_dData[XMLControl._LEVEL_1]);
                i3Level = int.Parse(_dData[XMLControl._LEVEL_3]);
                i50Level = int.Parse(_dData[XMLControl._LEVEL_50]);
            }

            Timer oTimer = new Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 1000;
            oTimer.Tick += OTimer_Tick;

            oTimer.Start();

        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _dData.Clear();

            _dData.Add(XMLControl._TICK, iTick.ToString());
            _dData.Add(XMLControl._TOTAL, iTotal.ToString());
            _dData.Add(XMLControl._LEVEL_1, i1Level.ToString());
            _dData.Add(XMLControl._LEVEL_3, i3Level.ToString());
            _dData.Add(XMLControl._LEVEL_50, i50Level.ToString());

            _xml.fXML_Writer(strPath, _dData);
        }

        /// <summary>
        /// 타이머에서 호출할 Event (interval 간격 기준)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal += iTick;

            lblTickPoint.Text = string.Format("Total : {0} (1: {1}, 3: {2}, 50: {3})",
                iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }
        /// <summary>
        /// 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;

            switch (obtn.Name)
            {
                case "btn1Add":
                    if (iTotal > 100)
                    {
                        iTotal -= 100;
                        i1Level++;
                        i1Add = i1Level * 1;
                    }
                    break;
                case "btn3Add":
                    if (iTotal > 300)
                    {
                        iTotal -= 300;
                        i3Level++;
                        i3Add = i3Level * 3;
                    }
                    break;
                case "btn50Add":
                    if (iTotal > 5000)
                    {
                        iTotal -= 5000;
                        i50Level++;
                        i50Add = i50Level * 50;
                    }
                    break;
                default:
                    break;
            }
        }


    }
}
