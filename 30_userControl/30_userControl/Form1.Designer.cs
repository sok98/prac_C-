﻿namespace _30_userControl
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
            this.lboxList = new System.Windows.Forms.ListBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.ucInfo2 = new _30_userControl.UCInfo();
            this.ucInfo1 = new _30_userControl.UCInfo();
            this.ucInfo3 = new _30_userControl.UCInfo();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 15;
            this.lboxList.Location = new System.Drawing.Point(12, 344);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(769, 184);
            this.lboxList.TabIndex = 3;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pMain.Controls.Add(this.ucInfo2);
            this.pMain.Controls.Add(this.ucInfo1);
            this.pMain.Controls.Add(this.ucInfo3);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(769, 317);
            this.pMain.TabIndex = 4;
            // 
            // ucInfo2
            // 
            this.ucInfo2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucInfo2.Location = new System.Drawing.Point(267, 14);
            this.ucInfo2.Name = "ucInfo2";
            this.ucInfo2.Size = new System.Drawing.Size(234, 285);
            this.ucInfo2.TabIndex = 1;
            this.ucInfo2.UserFace = global::_30_userControl.Properties.Resources._12;
            this.ucInfo2.UserMoney = "5천만원";
            this.ucInfo2.UserName = "아무개";
            this.ucInfo2.UserNo = "2";
            // 
            // ucInfo1
            // 
            this.ucInfo1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucInfo1.Location = new System.Drawing.Point(14, 14);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(234, 285);
            this.ucInfo1.TabIndex = 0;
            this.ucInfo1.UserFace = global::_30_userControl.Properties.Resources._13;
            this.ucInfo1.UserMoney = "2천만원";
            this.ucInfo1.UserName = "홍길동";
            this.ucInfo1.UserNo = "1";
            // 
            // ucInfo3
            // 
            this.ucInfo3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucInfo3.Location = new System.Drawing.Point(518, 14);
            this.ucInfo3.Name = "ucInfo3";
            this.ucInfo3.Size = new System.Drawing.Size(234, 285);
            this.ucInfo3.TabIndex = 2;
            this.ucInfo3.UserFace = global::_30_userControl.Properties.Resources._11;
            this.ucInfo3.UserMoney = "1천만원";
            this.ucInfo3.UserName = "김철수";
            this.ucInfo3.UserNo = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 539);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.lboxList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCInfo ucInfo1;
        private UCInfo ucInfo2;
        private UCInfo ucInfo3;
        private System.Windows.Forms.ListBox lboxList;
        private System.Windows.Forms.Panel pMain;
    }
}

