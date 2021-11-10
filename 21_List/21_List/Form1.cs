using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_List
{
    public partial class Form1 : Form
    {

        List<string> _strList = new List<string>();
        List<int> _intList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            //dgViewList.Columns.Add("dgValue", "Value");
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "picCake":
                    strSelectText = "cake";
                    break;
                case "picBurger":
                    strSelectText = "burger";
                    break;
                case "picPizza":
                    strSelectText = "pizza";
                    break;
                case "picIcecream":
                    strSelectText = "icecream";
                    break;
            }

            _strList.Add(strSelectText);

            fUIDisplay();
            fDataGridDisplay();
        }

        private void fUIDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza = 0;
            int iIce = 0;

            foreach (string item in _strList)
            {
                switch (item)
                {
                    case "cake":
                        iCake++;
                        break;
                    case "burger":
                        iBurger++;
                        break;
                    case "pizza":
                        iPizza++;
                        break;
                    case "icecream":
                        iIce++;
                        break;
                }
            }

            lblCakeCnt.Text = iCake.ToString();
            lblBurgerCnt.Text = iBurger.ToString();
            lblPizzaCnt.Text = iPizza.ToString();
            lblIcecreamCnt.Text = iIce.ToString();

            lblTotal.Text = _strList.Count.ToString();
        }
        private void fDataGridDisplay()
        {

            //dgViewList.Rows.Clear();
            //foreach (string item in _strList)
            //{
            //    dgViewList.Rows.Add(item);
            //}

            dgViewList.DataSource = _strList.Select(x => new { Value = x }).ToList();

            foreach (DataGridViewRow row in dgViewList.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
