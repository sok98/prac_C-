namespace _31_lambda
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.lblStepCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 38);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Event 함수를 호출";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(164, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(146, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "무명 메소드 사용";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(316, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(146, 38);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "람다식 사용";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(387, 63);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 15;
            this.lboxResult.Location = new System.Drawing.Point(12, 92);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(450, 214);
            this.lboxResult.TabIndex = 4;
            // 
            // lblStepCheck
            // 
            this.lblStepCheck.Location = new System.Drawing.Point(12, 63);
            this.lblStepCheck.Name = "lblStepCheck";
            this.lblStepCheck.Size = new System.Drawing.Size(281, 23);
            this.lblStepCheck.TabIndex = 5;
            this.lblStepCheck.Text = "-";
            this.lblStepCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 317);
            this.Controls.Add(this.lblStepCheck);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Label lblStepCheck;
    }
}

