namespace _11_struct
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.btnPlayer1 = new System.Windows.Forms.RadioButton();
            this.btnPlayer2 = new System.Windows.Forms.RadioButton();
            this.lboxPlayer1 = new System.Windows.Forms.ListBox();
            this.lboxPlayer2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Player는 한번씩 돌아가면서 그림을 선택합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "- 각 5회 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리합니다.";
            // 
            // pic1
            // 
            this.pic1.Image = global::_11_struct.Properties.Resources._1;
            this.pic1.Location = new System.Drawing.Point(15, 71);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(147, 176);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::_11_struct.Properties.Resources._2;
            this.pic2.Location = new System.Drawing.Point(168, 71);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(147, 176);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::_11_struct.Properties.Resources._3;
            this.pic3.Location = new System.Drawing.Point(321, 71);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(147, 176);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 4;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pic4.Location = new System.Drawing.Point(474, 71);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(147, 176);
            this.pic4.TabIndex = 5;
            this.pic4.TabStop = false;
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.AutoSize = true;
            this.btnPlayer1.Location = new System.Drawing.Point(15, 265);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(77, 19);
            this.btnPlayer1.TabIndex = 6;
            this.btnPlayer1.TabStop = true;
            this.btnPlayer1.Text = "Player1";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.AutoSize = true;
            this.btnPlayer2.Location = new System.Drawing.Point(321, 265);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(77, 19);
            this.btnPlayer2.TabIndex = 7;
            this.btnPlayer2.TabStop = true;
            this.btnPlayer2.Text = "Player2";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            // 
            // lboxPlayer1
            // 
            this.lboxPlayer1.FormattingEnabled = true;
            this.lboxPlayer1.ItemHeight = 15;
            this.lboxPlayer1.Location = new System.Drawing.Point(15, 291);
            this.lboxPlayer1.Name = "lboxPlayer1";
            this.lboxPlayer1.Size = new System.Drawing.Size(300, 139);
            this.lboxPlayer1.TabIndex = 8;
            // 
            // lboxPlayer2
            // 
            this.lboxPlayer2.FormattingEnabled = true;
            this.lboxPlayer2.ItemHeight = 15;
            this.lboxPlayer2.Location = new System.Drawing.Point(321, 291);
            this.lboxPlayer2.Name = "lboxPlayer2";
            this.lboxPlayer2.Size = new System.Drawing.Size(300, 139);
            this.lboxPlayer2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 443);
            this.Controls.Add(this.lboxPlayer2);
            this.Controls.Add(this.lboxPlayer1);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.RadioButton btnPlayer1;
        private System.Windows.Forms.RadioButton btnPlayer2;
        private System.Windows.Forms.ListBox lboxPlayer1;
        private System.Windows.Forms.ListBox lboxPlayer2;
    }
}

