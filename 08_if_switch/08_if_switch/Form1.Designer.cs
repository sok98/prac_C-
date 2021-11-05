namespace _08_if_switch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.resultNum = new System.Windows.Forms.Label();
            this.resultDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "요일선택)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number2)";
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(211, 28);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(120, 23);
            this.btnNum.TabIndex = 3;
            this.btnNum.Text = "Number 비교";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(211, 136);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(120, 23);
            this.btnDay.TabIndex = 4;
            this.btnDay.Text = "선택요일 확인";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(14, 137);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(162, 23);
            this.cboxDay.TabIndex = 5;
            this.cboxDay.Text = "월";
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(15, 30);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(69, 25);
            this.nNumber1.TabIndex = 6;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(110, 30);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(69, 25);
            this.nNumber2.TabIndex = 7;
            // 
            // resultNum
            // 
            this.resultNum.AutoSize = true;
            this.resultNum.Location = new System.Drawing.Point(12, 69);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(15, 15);
            this.resultNum.TabIndex = 8;
            this.resultNum.Text = "-";
            // 
            // resultDay
            // 
            this.resultDay.AutoSize = true;
            this.resultDay.Location = new System.Drawing.Point(12, 176);
            this.resultDay.Name = "resultDay";
            this.resultDay.Size = new System.Drawing.Size(15, 15);
            this.resultDay.TabIndex = 9;
            this.resultDay.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 231);
            this.Controls.Add(this.resultDay);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.Label resultNum;
        private System.Windows.Forms.Label resultDay;
    }
}

