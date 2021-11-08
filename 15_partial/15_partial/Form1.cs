using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_partial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cData _Data = new cData();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumItem item in (EnumItem[])Enum.GetValues(typeof(EnumItem)))
                cboxItem.Items.Add(item.ToString());

            foreach (EnumRate rate in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
                cboxRate.Items.Add(rate.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataDefault();

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);
            _Data.ICount = (int)numCount.Value;

            if (!string.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxError.Text = _Data.StrErrorName;
                return;
            }

            tboxError.Text = "";
            double dPrice = _Data.fitemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tboxResult.Text = _Data.DTotalPrice.ToString() + "원";
        }
    }
}
