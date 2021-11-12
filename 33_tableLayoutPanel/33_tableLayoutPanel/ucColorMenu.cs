using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_tableLayoutPanel
{
    public partial class ucColorMenu : UserControl
    {
        // 1) delegate event 선언
        //public delegate void delColorSender(object oSender, Color oColor);
        //public event delColorSender eColorSender;

        // 2) 기본 eventHandler
        //public event EventHandler eColorEventHandler;

        // 3) 제네릭 형태의 delegate 사용
        public event Action<Button, Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                Button obtn = new Button();

                obtn.Name = "btn"+i;
                obtn.Text = $"P{i} 색상 변경";
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 20, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                flowLayoutPanel1.Controls.Add(obtn);
            }

        }

        private void Obtn_Click(object sender, EventArgs e)
        {
            //eColorSender(sender, pColor.BackColor); // 1)
            //eColorEventHandler(sender, e);          // 2)
            eColorAction((Button)sender, pColor.BackColor); // 3)
        }

        private void PColor_Click(object sender, System.EventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();
            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }

        public void fButtonColorChange(ucPanel oPanel)
        {
            string strbtnName = string.Empty;
            switch (oPanel.Name)
            {
                case "ucP1":
                    strbtnName = "btn1";
                    break;
                case "ucP2":
                    strbtnName = "btn2";
                    break;
                case "ucP3":
                    strbtnName = "btn3";
                    break;
                case "ucP4":
                    strbtnName = "btn4";
                    break;
            }
            fBtnSearch(strbtnName, oPanel.BackColor);
        }

        private void fBtnSearch(string strButtonName, Color oColor)
        {
            foreach(var item in flowLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    Button obtn = item as Button;

                    if (obtn.Name.Equals(strButtonName))
                    {
                        obtn.BackColor = oColor;
                    }
                }
            }
        }


    }
}
