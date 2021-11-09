using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_streamReader_streamWrite
{
    public partial class Form1 : Form
    {
        XMLControl _XML = new XMLControl();
        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        public string strEnter = "\r\n";

        private void btnConfigSet_Click(object sender, EventArgs e)
        {

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString() + strEnter);

            tboxConfigData.Text = sb.ToString();

            _dData.Clear();
            _dData.Add(XMLControl._TEXT_DATA, strText);
            _dData.Add(XMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(XMLControl._NUMBER_DATA, iNumber.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;    // 프로그램 실행 파일 위치
            SFDialog.FileName = "*.xml";    // 파일 이름
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";    // 파일 형식

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                //StreamWriter swSFDialog = new StreamWriter(strFilePath);

                //swSFDialog.WriteLine(tboxConfigData.Text);
                //swSFDialog.Close();

                //File.WriteAllText(strFilePath, tboxConfigData.Text);

                _XML.fXML_Writer(strFilePath, _dData);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;    // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.xml";    // 파일 이름
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";    // 파일 형식

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                //StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                //while (srOFDialog.EndOfStream == false)
                //{
                //    sb.Append(srOFDialog.ReadLine());
                //    sb.Append(strEnter);
                //}

                //string[] strLoad = File.ReadAllLines(strFilePath);

                sb.Append(File.ReadAllText(strFilePath));

                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }

        private void btnConfigLoad_Click(object sender, EventArgs e)
        {
            if (tboxConfigData.Text != "")
            {
                string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                tboxData.Text = strConfig[0];
                cboxData.Checked = bool.Parse(strConfig[1]);
                numData.Value = int.Parse(strConfig[2]);
            }

        }
    }
}
