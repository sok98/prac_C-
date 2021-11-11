using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_userControl
{
    public partial class UCInfo : UserControl
    {
        public delegate int delEvent(object Sender, string strText);    // delegate 선언
        public event delEvent eventdelSender;   // delegate event 선언

        [Category("UserProperty"), Description("Image")]
        public Image UserFace
        {
            get { return this.pBox.Image; }
            set { this.pBox.Image = value; }
        }

        [Category("UserProperty"), Description("No")]
        public string UserNo
        {
            get { return this.lblNum.Text; }
            set { this.lblNum.Text = value; }
        }

        [Category("UserProperty"), Description("현상범 이름")]
        public string UserName
        {
            get { return this.lblName.Text; }
            set { this.lblName.Text = value; }
        }

        [Category("UserProperty"), Description("현상금")]
        public string UserMoney
        {
            get { return this.lblMoney.Text; }
            set { this.lblMoney.Text = value; }
        }

        public UCInfo()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string strText = string.Empty;
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    strText = string.Format("{0}은(는) 금액 {1}으로 수배중입니다.", UserName, UserMoney);
                    break;
                case "btnStop":
                    strText = string.Format("{0}은(는) 수배 정지 상태 입니다.", UserName);
                    this.BackColor = Color.Yellow;
                    break;
                case "btnCatch":
                    strText = string.Format("{0}은(는) 검거되었습니다.", UserName);
                    this.BackColor = Color.Green;
                    break;
            }
            if (eventdelSender != null) eventdelSender(this, strText);
        }
    }
}
