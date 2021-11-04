namespace _01_string
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
            this.lblMain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblContain = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.lblToLower = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtContain = new System.Windows.Forms.Label();
            this.txtToLower = new System.Windows.Forms.Label();
            this.txtSubstring = new System.Windows.Forms.Label();
            this.txtToUpper = new System.Windows.Forms.Label();
            this.txtTrim = new System.Windows.Forms.Label();
            this.txtSplit1 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.Label();
            this.txtEquals = new System.Windows.Forms.Label();
            this.txtSplit3 = new System.Windows.Forms.Label();
            this.txtSplit2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(164, 31);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(117, 15);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Hello, Test, Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(41, 105);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(57, 15);
            this.lblContain.TabIndex = 2;
            this.lblContain.Text = "Contain";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(41, 139);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(51, 15);
            this.lblEquals.TabIndex = 3;
            this.lblEquals.Text = "Equals";
            // 
            // lblToUpper
            // 
            this.lblToUpper.AutoSize = true;
            this.lblToUpper.Location = new System.Drawing.Point(312, 180);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(62, 15);
            this.lblToUpper.TabIndex = 4;
            this.lblToUpper.Text = "ToUpper";
            // 
            // lblToLower
            // 
            this.lblToLower.AutoSize = true;
            this.lblToLower.Location = new System.Drawing.Point(312, 139);
            this.lblToLower.Name = "lblToLower";
            this.lblToLower.Size = new System.Drawing.Size(63, 15);
            this.lblToLower.TabIndex = 5;
            this.lblToLower.Text = "ToLower";
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(312, 105);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(68, 15);
            this.lblSubstring.TabIndex = 6;
            this.lblSubstring.Text = "Substring";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(312, 218);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(33, 15);
            this.lblTrim.TabIndex = 7;
            this.lblTrim.Text = "Trim";
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(44, 255);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(35, 15);
            this.lblSplit.TabIndex = 8;
            this.lblSplit.Text = "Split";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(41, 218);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(60, 15);
            this.lblReplace.TabIndex = 9;
            this.lblReplace.Text = "Replace";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(41, 180);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 15);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length";
            // 
            // txtContain
            // 
            this.txtContain.AutoSize = true;
            this.txtContain.Location = new System.Drawing.Point(137, 105);
            this.txtContain.Name = "txtContain";
            this.txtContain.Size = new System.Drawing.Size(15, 15);
            this.txtContain.TabIndex = 11;
            this.txtContain.Text = "-";
            // 
            // txtToLower
            // 
            this.txtToLower.AutoSize = true;
            this.txtToLower.Location = new System.Drawing.Point(428, 139);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(15, 15);
            this.txtToLower.TabIndex = 12;
            this.txtToLower.Text = "-";
            // 
            // txtSubstring
            // 
            this.txtSubstring.AutoSize = true;
            this.txtSubstring.Location = new System.Drawing.Point(428, 105);
            this.txtSubstring.Name = "txtSubstring";
            this.txtSubstring.Size = new System.Drawing.Size(15, 15);
            this.txtSubstring.TabIndex = 13;
            this.txtSubstring.Text = "-";
            // 
            // txtToUpper
            // 
            this.txtToUpper.AutoSize = true;
            this.txtToUpper.Location = new System.Drawing.Point(428, 180);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(15, 15);
            this.txtToUpper.TabIndex = 14;
            this.txtToUpper.Text = "-";
            // 
            // txtTrim
            // 
            this.txtTrim.AutoSize = true;
            this.txtTrim.Location = new System.Drawing.Point(428, 218);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(15, 15);
            this.txtTrim.TabIndex = 15;
            this.txtTrim.Text = "-";
            // 
            // txtSplit1
            // 
            this.txtSplit1.AutoSize = true;
            this.txtSplit1.Location = new System.Drawing.Point(137, 255);
            this.txtSplit1.Name = "txtSplit1";
            this.txtSplit1.Size = new System.Drawing.Size(15, 15);
            this.txtSplit1.TabIndex = 16;
            this.txtSplit1.Text = "-";
            // 
            // txtReplace
            // 
            this.txtReplace.AutoSize = true;
            this.txtReplace.Location = new System.Drawing.Point(137, 218);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(15, 15);
            this.txtReplace.TabIndex = 17;
            this.txtReplace.Text = "-";
            // 
            // txtLength
            // 
            this.txtLength.AutoSize = true;
            this.txtLength.Location = new System.Drawing.Point(137, 180);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(15, 15);
            this.txtLength.TabIndex = 18;
            this.txtLength.Text = "-";
            // 
            // txtEquals
            // 
            this.txtEquals.AutoSize = true;
            this.txtEquals.Location = new System.Drawing.Point(137, 139);
            this.txtEquals.Name = "txtEquals";
            this.txtEquals.Size = new System.Drawing.Size(15, 15);
            this.txtEquals.TabIndex = 19;
            this.txtEquals.Text = "-";
            // 
            // txtSplit3
            // 
            this.txtSplit3.AutoSize = true;
            this.txtSplit3.Location = new System.Drawing.Point(137, 305);
            this.txtSplit3.Name = "txtSplit3";
            this.txtSplit3.Size = new System.Drawing.Size(15, 15);
            this.txtSplit3.TabIndex = 20;
            this.txtSplit3.Text = "-";
            // 
            // txtSplit2
            // 
            this.txtSplit2.AutoSize = true;
            this.txtSplit2.Location = new System.Drawing.Point(137, 280);
            this.txtSplit2.Name = "txtSplit2";
            this.txtSplit2.Size = new System.Drawing.Size(15, 15);
            this.txtSplit2.TabIndex = 21;
            this.txtSplit2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 427);
            this.Controls.Add(this.txtSplit2);
            this.Controls.Add(this.txtSplit3);
            this.Controls.Add(this.txtEquals);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtSplit1);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtSubstring);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtContain);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblToLower);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblContain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblToUpper;
        private System.Windows.Forms.Label lblToLower;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label txtContain;
        private System.Windows.Forms.Label txtToLower;
        private System.Windows.Forms.Label txtSubstring;
        private System.Windows.Forms.Label txtToUpper;
        private System.Windows.Forms.Label txtTrim;
        private System.Windows.Forms.Label txtSplit1;
        private System.Windows.Forms.Label txtReplace;
        private System.Windows.Forms.Label txtLength;
        private System.Windows.Forms.Label txtEquals;
        private System.Windows.Forms.Label txtSplit3;
        private System.Windows.Forms.Label txtSplit2;
    }
}

