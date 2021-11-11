using System;
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

        public Form1()
        {
            InitializeComponent();
            _locationX = this.Location.X;
            _locationY = this.Location.Y;
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
