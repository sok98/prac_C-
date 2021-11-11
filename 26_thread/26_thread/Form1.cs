﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_thread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            성재,
            은광,
            창섭,
            민혁,
            현식
        }

        int _locationX = 0;
        int _locationY = 0;

        List<Play> lPlay = new List<Play>();

        public Form1()
        {
            InitializeComponent();
            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            foreach (Play oPlayForm in lPlay)
            {
                oPlayForm.ThreadAbort();    // 프로그램 종료 시점이라서 강제로 Thread 해제
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayer.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY + pl.Height * i);
                pl.eventdelMessage += Pl_eventdelMessage;

                pl.Show();
                pl.fThreadStart();

                lPlay.Add(pl);
            }


        }

        private int Pl_eventdelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    Play oPlayForm = sender as Play;
                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", oPlayForm.StrName, strResult));

                }));
            }
            return 0;
        }
    }
}
