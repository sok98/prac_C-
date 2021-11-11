using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_exception_sample
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();

        public Form1()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cdialogColor.ShowDialog();
            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cdialogColor.Color;
            }

            lblColorInfo.Text = pColor.BackColor.ToString();
        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColorInfo.Text = pColor.BackColor.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                dColor.Add(oColor.ToString(), oColor);
                LBoxRefresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dColor.Remove(lboxColor.SelectedItem.ToString());
                LBoxRefresh();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LBoxRefresh()
        {
            try
            {
                lboxColor.Items.Clear();
                foreach (string okey in dColor.Keys)
                {
                    lboxColor.Items.Add(okey);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = dColor[lboxColor.SelectedItem.ToString()];
        }

        private void panel_Click(object sender, MouseEventArgs e)
        {
            try
            {
                Panel oPanel = sender as Panel;
                oPanel.BackColor = oSelectColor;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
