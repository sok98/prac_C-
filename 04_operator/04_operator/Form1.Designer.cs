﻿namespace _04_operator
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
            this.tboxNum1 = new System.Windows.Forms.TextBox();
            this.tboxNum2 = new System.Windows.Forms.TextBox();
            this.tboxBit = new System.Windows.Forms.TextBox();
            this.tboxBool = new System.Windows.Forms.TextBox();
            this.tboxAfter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNum1
            // 
            this.tboxNum1.Location = new System.Drawing.Point(12, 12);
            this.tboxNum1.Name = "tboxNum1";
            this.tboxNum1.Size = new System.Drawing.Size(120, 25);
            this.tboxNum1.TabIndex = 0;
            this.tboxNum1.Text = "0";
            this.tboxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxNum1.TextChanged += new System.EventHandler(this.tboxNum1_TextChanged);
            // 
            // tboxNum2
            // 
            this.tboxNum2.Location = new System.Drawing.Point(12, 95);
            this.tboxNum2.Name = "tboxNum2";
            this.tboxNum2.Size = new System.Drawing.Size(120, 25);
            this.tboxNum2.TabIndex = 2;
            this.tboxNum2.Text = "0";
            this.tboxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxBit
            // 
            this.tboxBit.Enabled = false;
            this.tboxBit.Location = new System.Drawing.Point(12, 43);
            this.tboxBit.Name = "tboxBit";
            this.tboxBit.Size = new System.Drawing.Size(120, 25);
            this.tboxBit.TabIndex = 3;
            this.tboxBit.Text = "0";
            this.tboxBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxBool
            // 
            this.tboxBool.Enabled = false;
            this.tboxBool.Location = new System.Drawing.Point(138, 95);
            this.tboxBool.Name = "tboxBool";
            this.tboxBool.Size = new System.Drawing.Size(120, 25);
            this.tboxBool.TabIndex = 4;
            this.tboxBool.Text = "0";
            this.tboxBool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxAfter
            // 
            this.tboxAfter.Location = new System.Drawing.Point(138, 12);
            this.tboxAfter.Name = "tboxAfter";
            this.tboxAfter.Size = new System.Drawing.Size(120, 25);
            this.tboxAfter.TabIndex = 6;
            this.tboxAfter.Text = "0";
            this.tboxAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "-=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "+=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(78, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 51);
            this.button6.TabIndex = 14;
            this.button6.Text = "a++";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(138, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 51);
            this.button7.TabIndex = 13;
            this.button7.Text = "&&";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(198, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 51);
            this.button8.TabIndex = 12;
            this.button8.Text = "||";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "++a";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxAfter);
            this.Controls.Add(this.tboxBool);
            this.Controls.Add(this.tboxBit);
            this.Controls.Add(this.tboxNum2);
            this.Controls.Add(this.tboxNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNum1;
        private System.Windows.Forms.TextBox tboxNum2;
        private System.Windows.Forms.TextBox tboxBit;
        private System.Windows.Forms.TextBox tboxBool;
        private System.Windows.Forms.TextBox tboxAfter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
    }
}

