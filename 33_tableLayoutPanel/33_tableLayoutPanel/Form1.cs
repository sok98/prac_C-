using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_tableLayoutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ucMenu.eColorSender += UcMenu_eColorSender;
            ucMenu.eColorAction += UcMenu_eColorAction;
            ucP1.eLabelDoubleClickHandler += UcP_eLabelDoubleClickHandler;
            ucP2.eLabelDoubleClickHandler += UcP_eLabelDoubleClickHandler;
            ucP3.eLabelDoubleClickHandler += UcP_eLabelDoubleClickHandler;
            ucP4.eLabelDoubleClickHandler += UcP_eLabelDoubleClickHandler;
        }

        private void UcP_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ucMenu.fButtonColorChange((ucPanel)sender);
        }

        private void UcMenu_eColorAction(Button btn, Color arg2)
        {
            string strPanelName = string.Empty;

            switch (btn.Name)
            {
                case "btn1":
                    ucP1.BackColor = arg2;
                    break;
                case "btn2":
                    ucP2.BackColor = arg2;
                    break;
                case "btn3":
                    ucP3.BackColor = arg2;
                    break;
                case "btn4":
                    ucP4.BackColor = arg2;
                    break;
                default:
                    break;
            }
        }

        //private void UcMenu_eColorSender(object oSender, Color oColor)
        //{

        //}
    }
}
