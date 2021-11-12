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
    public partial class ucPanel : UserControl
    {
        public ucPanel()
        {
            InitializeComponent();
        }

        private void PanelSizeChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("({0},{1})", label1.Width, label1.Height);
        }
    }
}
