﻿namespace _15_partial
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
            this.lboxItem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.cboxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxItem
            // 
            this.lboxItem.FormattingEnabled = true;
            this.lboxItem.ItemHeight = 15;
            this.lboxItem.Location = new System.Drawing.Point(12, 14);
            this.lboxItem.Name = "lboxItem";
            this.lboxItem.Size = new System.Drawing.Size(235, 229);
            this.lboxItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "물건";
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(256, 32);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(133, 23);
            this.cboxItem.TabIndex = 2;
            // 
            // cboxRate
            // 
            this.cboxRate.FormattingEnabled = true;
            this.cboxRate.Location = new System.Drawing.Point(256, 95);
            this.cboxRate.Name = "cboxRate";
            this.cboxRate.Size = new System.Drawing.Size(133, 23);
            this.cboxRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "할인율 (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "개수";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(256, 156);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(133, 25);
            this.numCount.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(256, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(12, 249);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(235, 25);
            this.tboxResult.TabIndex = 9;
            // 
            // tboxError
            // 
            this.tboxError.ForeColor = System.Drawing.Color.Red;
            this.tboxError.Location = new System.Drawing.Point(12, 280);
            this.tboxError.Name = "tboxError";
            this.tboxError.Size = new System.Drawing.Size(377, 25);
            this.tboxError.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 339);
            this.Controls.Add(this.tboxError);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.ComboBox cboxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxError;
    }
}

