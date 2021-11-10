namespace _21_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.picCake = new System.Windows.Forms.PictureBox();
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.picIcecream = new System.Windows.Forms.PictureBox();
            this.lblCakeCnt = new System.Windows.Forms.Label();
            this.lblBurgerCnt = new System.Windows.Forms.Label();
            this.lblPizzaCnt = new System.Windows.Forms.Label();
            this.lblIcecreamCnt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcecream)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblIcecreamCnt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPizzaCnt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBurgerCnt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picIcecream, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.picPizza, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBurger, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picCake, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCakeCnt, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.7963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.2037F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "- 선호하는 항목을 선택해 주세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Count : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(127, 278);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "- 나의 Data를 화면에 보여줍니다.";
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(153, 348);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 27;
            this.dgViewList.Size = new System.Drawing.Size(273, 299);
            this.dgViewList.TabIndex = 3;
            // 
            // picCake
            // 
            this.picCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCake.Image = ((System.Drawing.Image)(resources.GetObject("picCake.Image")));
            this.picCake.Location = new System.Drawing.Point(3, 3);
            this.picCake.Name = "picCake";
            this.picCake.Size = new System.Drawing.Size(132, 174);
            this.picCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCake.TabIndex = 0;
            this.picCake.TabStop = false;
            this.picCake.Click += new System.EventHandler(this.pic_Click);
            // 
            // picBurger
            // 
            this.picBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBurger.Image = ((System.Drawing.Image)(resources.GetObject("picBurger.Image")));
            this.picBurger.Location = new System.Drawing.Point(141, 3);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(132, 174);
            this.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurger.TabIndex = 1;
            this.picBurger.TabStop = false;
            this.picBurger.Click += new System.EventHandler(this.pic_Click);
            // 
            // picPizza
            // 
            this.picPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPizza.Image = ((System.Drawing.Image)(resources.GetObject("picPizza.Image")));
            this.picPizza.Location = new System.Drawing.Point(279, 3);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(132, 174);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 2;
            this.picPizza.TabStop = false;
            this.picPizza.Click += new System.EventHandler(this.pic_Click);
            // 
            // picIcecream
            // 
            this.picIcecream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcecream.Image = ((System.Drawing.Image)(resources.GetObject("picIcecream.Image")));
            this.picIcecream.Location = new System.Drawing.Point(417, 3);
            this.picIcecream.Name = "picIcecream";
            this.picIcecream.Size = new System.Drawing.Size(133, 174);
            this.picIcecream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcecream.TabIndex = 3;
            this.picIcecream.TabStop = false;
            this.picIcecream.Click += new System.EventHandler(this.pic_Click);
            // 
            // lblCakeCnt
            // 
            this.lblCakeCnt.AutoSize = true;
            this.lblCakeCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCakeCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCakeCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCakeCnt.Location = new System.Drawing.Point(3, 183);
            this.lblCakeCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblCakeCnt.Name = "lblCakeCnt";
            this.lblCakeCnt.Size = new System.Drawing.Size(132, 30);
            this.lblCakeCnt.TabIndex = 4;
            this.lblCakeCnt.Text = "0";
            this.lblCakeCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBurgerCnt
            // 
            this.lblBurgerCnt.AutoSize = true;
            this.lblBurgerCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBurgerCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBurgerCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBurgerCnt.Location = new System.Drawing.Point(141, 183);
            this.lblBurgerCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblBurgerCnt.Name = "lblBurgerCnt";
            this.lblBurgerCnt.Size = new System.Drawing.Size(132, 30);
            this.lblBurgerCnt.TabIndex = 5;
            this.lblBurgerCnt.Text = "0";
            this.lblBurgerCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPizzaCnt
            // 
            this.lblPizzaCnt.AutoSize = true;
            this.lblPizzaCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPizzaCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPizzaCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPizzaCnt.Location = new System.Drawing.Point(279, 183);
            this.lblPizzaCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblPizzaCnt.Name = "lblPizzaCnt";
            this.lblPizzaCnt.Size = new System.Drawing.Size(132, 30);
            this.lblPizzaCnt.TabIndex = 6;
            this.lblPizzaCnt.Text = "0";
            this.lblPizzaCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcecreamCnt
            // 
            this.lblIcecreamCnt.AutoSize = true;
            this.lblIcecreamCnt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIcecreamCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIcecreamCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIcecreamCnt.Location = new System.Drawing.Point(417, 183);
            this.lblIcecreamCnt.Margin = new System.Windows.Forms.Padding(3);
            this.lblIcecreamCnt.Name = "lblIcecreamCnt";
            this.lblIcecreamCnt.Size = new System.Drawing.Size(133, 30);
            this.lblIcecreamCnt.TabIndex = 7;
            this.lblIcecreamCnt.Text = "0";
            this.lblIcecreamCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 659);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcecream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIcecreamCnt;
        private System.Windows.Forms.Label lblPizzaCnt;
        private System.Windows.Forms.Label lblBurgerCnt;
        private System.Windows.Forms.PictureBox picIcecream;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.PictureBox picBurger;
        private System.Windows.Forms.PictureBox picCake;
        private System.Windows.Forms.Label lblCakeCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgViewList;
    }
}

