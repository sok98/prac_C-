namespace _22_Dictionary
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblDCnt = new System.Windows.Forms.Label();
            this.lblCCnt = new System.Windows.Forms.Label();
            this.lblBCnt = new System.Windows.Forms.Label();
            this.picD = new System.Windows.Forms.PictureBox();
            this.picC = new System.Windows.Forms.PictureBox();
            this.picB = new System.Windows.Forms.PictureBox();
            this.picA = new System.Windows.Forms.PictureBox();
            this.lblACnt = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(157, 400);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 27;
            this.dgViewList.Size = new System.Drawing.Size(273, 299);
            this.dgViewList.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "- Dictionary의 Data를 화면에 보여줍니다.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(154, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0 / 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "투표 진행 현황 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "- 선호하는 항목을 선택해 주세요.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblC, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDCnt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCCnt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBCnt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.picC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblACnt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblA, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.1244F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8756F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 234);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblD.Location = new System.Drawing.Point(417, 209);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(133, 25);
            this.lblD.TabIndex = 11;
            this.lblD.Text = "보영";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblC.Location = new System.Drawing.Point(279, 209);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(132, 25);
            this.lblC.TabIndex = 10;
            this.lblC.Text = "혜인";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Location = new System.Drawing.Point(141, 209);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(132, 25);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "신혜";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDCnt
            // 
            this.lblDCnt.AutoSize = true;
            this.lblDCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDCnt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDCnt.Location = new System.Drawing.Point(417, 183);
            this.lblDCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblDCnt.Name = "lblDCnt";
            this.lblDCnt.Size = new System.Drawing.Size(133, 23);
            this.lblDCnt.TabIndex = 7;
            this.lblDCnt.Text = "0";
            this.lblDCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCCnt
            // 
            this.lblCCnt.AutoSize = true;
            this.lblCCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCCnt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCCnt.Location = new System.Drawing.Point(279, 183);
            this.lblCCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblCCnt.Name = "lblCCnt";
            this.lblCCnt.Size = new System.Drawing.Size(132, 23);
            this.lblCCnt.TabIndex = 6;
            this.lblCCnt.Text = "0";
            this.lblCCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBCnt
            // 
            this.lblBCnt.AutoSize = true;
            this.lblBCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBCnt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBCnt.Location = new System.Drawing.Point(141, 183);
            this.lblBCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblBCnt.Name = "lblBCnt";
            this.lblBCnt.Size = new System.Drawing.Size(132, 23);
            this.lblBCnt.TabIndex = 5;
            this.lblBCnt.Text = "0";
            this.lblBCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picD
            // 
            this.picD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picD.Image = global::_22_Dictionary.Properties.Resources._14;
            this.picD.Location = new System.Drawing.Point(417, 3);
            this.picD.Name = "picD";
            this.picD.Size = new System.Drawing.Size(133, 174);
            this.picD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD.TabIndex = 3;
            this.picD.TabStop = false;
            this.picD.Click += new System.EventHandler(this.pic_Click);
            // 
            // picC
            // 
            this.picC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picC.Image = global::_22_Dictionary.Properties.Resources._13;
            this.picC.Location = new System.Drawing.Point(279, 3);
            this.picC.Name = "picC";
            this.picC.Size = new System.Drawing.Size(132, 174);
            this.picC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC.TabIndex = 2;
            this.picC.TabStop = false;
            this.picC.Click += new System.EventHandler(this.pic_Click);
            // 
            // picB
            // 
            this.picB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB.Image = global::_22_Dictionary.Properties.Resources._12;
            this.picB.Location = new System.Drawing.Point(141, 3);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(132, 174);
            this.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB.TabIndex = 1;
            this.picB.TabStop = false;
            this.picB.Click += new System.EventHandler(this.pic_Click);
            // 
            // picA
            // 
            this.picA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picA.Image = global::_22_Dictionary.Properties.Resources._11;
            this.picA.Location = new System.Drawing.Point(3, 3);
            this.picA.Name = "picA";
            this.picA.Size = new System.Drawing.Size(132, 174);
            this.picA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picA.TabIndex = 0;
            this.picA.TabStop = false;
            this.picA.Click += new System.EventHandler(this.pic_Click);
            // 
            // lblACnt
            // 
            this.lblACnt.AutoSize = true;
            this.lblACnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblACnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblACnt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblACnt.Location = new System.Drawing.Point(3, 183);
            this.lblACnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblACnt.Name = "lblACnt";
            this.lblACnt.Size = new System.Drawing.Size(132, 23);
            this.lblACnt.TabIndex = 4;
            this.lblACnt.Text = "0";
            this.lblACnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA.Location = new System.Drawing.Point(3, 209);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(132, 25);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "보검";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(154, 305);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 15);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(16, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "투표자 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 716);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDCnt;
        private System.Windows.Forms.Label lblCCnt;
        private System.Windows.Forms.Label lblBCnt;
        private System.Windows.Forms.PictureBox picD;
        private System.Windows.Forms.PictureBox picC;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.PictureBox picA;
        private System.Windows.Forms.Label lblACnt;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label8;
    }
}

