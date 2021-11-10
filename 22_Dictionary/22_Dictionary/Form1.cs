using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Dictionary
{
    public partial class Form1 : Form
    {
        enum enBossName
        {
            보검,
            신혜,
            혜인,
            보영
        }

        enum enClassName
        {
            진,
            정국,
            슈가,
            지민,
            뷔,
            제이홉,
            은비,
            혜원,
            예나,
            채연,
            채원,
            민주,
            유리,
            유진,
            원영
        }

        Hashtable _ht = new Hashtable();
        Dictionary<string, string> _dic = new Dictionary<string, string>();

        int totalCnt = Enum.GetValues(typeof(enClassName)).Length;
        int playerCnt = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "picA":
                    strSelectText = enBossName.보검.ToString();
                    break;
                case "picB":
                    strSelectText = enBossName.신혜.ToString();
                    break;
                case "picC":
                    strSelectText = enBossName.혜인.ToString();
                    break;
                case "picD":
                    strSelectText = enBossName.보영.ToString();
                    break;
            }

            if (totalCnt > playerCnt)
            {
                enClassName enName = (enClassName)playerCnt;
                _dic.Add(enName.ToString(), strSelectText);

                playerCnt++;

                fUIDisplay(enName.ToString());
                fDataGridDisplay();

            }
            else
            {
                lblTotal.Text = "투표를 완료하였습니다.";
            }


        }
        private void fUIDisplay(string name)
        {
            int iA = 0;
            int iB = 0;
            int iC = 0;
            int iD = 0;

            foreach (string item in _dic.Values)
            {
                switch (item)
                {
                    case "보검":
                        iA++;
                        break;
                    case "신혜":
                        iB++;
                        break;
                    case "혜인":
                        iC++;
                        break;
                    case "보영":
                        iD++;
                        break;
                }
            }

            lblACnt.Text = iA.ToString();
            lblBCnt.Text = iB.ToString();
            lblCCnt.Text = iC.ToString();
            lblDCnt.Text = iD.ToString();

            lblTotal.Text = playerCnt.ToString() + " / " + totalCnt.ToString();
            lblName.Text = name;
        }
        private void fDataGridDisplay()
        {

            //dgViewList.Rows.Clear();
            //foreach (string item in _strList)
            //{
            //    dgViewList.Rows.Add(item);
            //}

            dgViewList.DataSource = _dic.ToArray();

            foreach (DataGridViewRow row in dgViewList.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
