namespace _10_while_dowhile
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSearchNum = new System.Windows.Forms.TextBox();
            this.btnChoice = new System.Windows.Forms.Button();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(15, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(205, 19);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0, 0, 0, 0, 0, 0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 15;
            this.lboxResult.Location = new System.Drawing.Point(15, 45);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(205, 169);
            this.lboxResult.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(240, 14);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(91, 23);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "로또 번호";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(15, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 3);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "1~100 안의 숫자를 선택 하세요";
            // 
            // tboxSearchNum
            // 
            this.tboxSearchNum.Location = new System.Drawing.Point(18, 286);
            this.tboxSearchNum.Name = "tboxSearchNum";
            this.tboxSearchNum.Size = new System.Drawing.Size(178, 25);
            this.tboxSearchNum.TabIndex = 4;
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(202, 285);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(129, 23);
            this.btnChoice.TabIndex = 5;
            this.btnChoice.Text = "선택 번호 뽑기";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(15, 328);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(256, 15);
            this.lblSearchResult.TabIndex = 6;
            this.lblSearchResult.Text = "- 뽑은 숫자 0을 0회만에 찾았습니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 370);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.tboxSearchNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSearchNum;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Label lblSearchResult;
    }
}

