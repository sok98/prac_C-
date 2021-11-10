using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_DataTable_DataSet
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // 학급들의 정보

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool bCheckisTable = false;
            if (ds.Tables.Contains(cboxClass.Text))
            {
                bCheckisTable = true;
            }

            DataTable dt = null;
            if (!bCheckisTable)
            {
                dt = new DataTable(cboxClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxClass.Text];
            }

            // Row 자료 등록
            DataRow row = dt.NewRow();

            row["NAME"] = tboxName.Text;

            if (rbtnM.Checked)
                row["SEX"] = "남자";
            else
                row["SEX"] = "여자";

            row["REF"] = tboxRef.Text;

            // 생성된 Row -> DataTable -> DataSet 에 등록
            if (bCheckisTable)
            {
                ds.Tables[cboxClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }

            ViewRefresh();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgViewClass.SelectedRows.Count != 0)
            {
                int iSelectRow = dgViewClass.SelectedRows[0].Index;
                ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);
                ViewRefresh();
            }
        }
        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }


        private void ViewRefresh()
        {
            dgViewClass.DataSource = ds.Tables[cboxViewClass.Text];

            // DataGridView Cell 정렬 및 Number 적용
            foreach (DataGridViewRow row in dgViewClass.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }
            dgViewClass.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
