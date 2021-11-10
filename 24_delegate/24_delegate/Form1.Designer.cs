namespace _24_delegate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnDow1 = new System.Windows.Forms.RadioButton();
            this.rbtnDow2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnEdge1 = new System.Windows.Forms.RadioButton();
            this.rbtnEdge2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cboxTopping1 = new System.Windows.Forms.CheckBox();
            this.cboxTopping2 = new System.Windows.Forms.CheckBox();
            this.cboxTopping3 = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lboxOrder = new System.Windows.Forms.ListBox();
            this.numEA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도우";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbtnDow1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtnDow2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rbtnDow1
            // 
            this.rbtnDow1.AutoSize = true;
            this.rbtnDow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnDow1.Location = new System.Drawing.Point(0, 0);
            this.rbtnDow1.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnDow1.Name = "rbtnDow1";
            this.rbtnDow1.Size = new System.Drawing.Size(182, 25);
            this.rbtnDow1.TabIndex = 0;
            this.rbtnDow1.TabStop = true;
            this.rbtnDow1.Text = "오리지널 (10000원)";
            this.rbtnDow1.UseVisualStyleBackColor = true;
            // 
            // rbtnDow2
            // 
            this.rbtnDow2.AutoSize = true;
            this.rbtnDow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnDow2.Location = new System.Drawing.Point(182, 0);
            this.rbtnDow2.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnDow2.Name = "rbtnDow2";
            this.rbtnDow2.Size = new System.Drawing.Size(183, 25);
            this.rbtnDow2.TabIndex = 1;
            this.rbtnDow2.TabStop = true;
            this.rbtnDow2.Text = "씬 (11000원)";
            this.rbtnDow2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "엣지";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rbtnEdge1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnEdge2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rbtnEdge1
            // 
            this.rbtnEdge1.AutoSize = true;
            this.rbtnEdge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnEdge1.Location = new System.Drawing.Point(0, 0);
            this.rbtnEdge1.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnEdge1.Name = "rbtnEdge1";
            this.rbtnEdge1.Size = new System.Drawing.Size(182, 25);
            this.rbtnEdge1.TabIndex = 0;
            this.rbtnEdge1.TabStop = true;
            this.rbtnEdge1.Text = "리치골드 (1000원)";
            this.rbtnEdge1.UseVisualStyleBackColor = true;
            // 
            // rbtnEdge2
            // 
            this.rbtnEdge2.AutoSize = true;
            this.rbtnEdge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnEdge2.Location = new System.Drawing.Point(182, 0);
            this.rbtnEdge2.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnEdge2.Name = "rbtnEdge2";
            this.rbtnEdge2.Size = new System.Drawing.Size(183, 25);
            this.rbtnEdge2.TabIndex = 1;
            this.rbtnEdge2.TabStop = true;
            this.rbtnEdge2.Text = "치즈크러스트 (2000원)";
            this.rbtnEdge2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Controls.Add(this.numEA);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "토핑";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cboxTopping1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboxTopping2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboxTopping3, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(210, 92);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cboxTopping1
            // 
            this.cboxTopping1.AutoSize = true;
            this.cboxTopping1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxTopping1.Location = new System.Drawing.Point(0, 0);
            this.cboxTopping1.Margin = new System.Windows.Forms.Padding(0);
            this.cboxTopping1.Name = "cboxTopping1";
            this.cboxTopping1.Size = new System.Drawing.Size(210, 30);
            this.cboxTopping1.TabIndex = 0;
            this.cboxTopping1.Text = "소세지 (1EA 500원)";
            this.cboxTopping1.UseVisualStyleBackColor = true;
            // 
            // cboxTopping2
            // 
            this.cboxTopping2.AutoSize = true;
            this.cboxTopping2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxTopping2.Location = new System.Drawing.Point(0, 30);
            this.cboxTopping2.Margin = new System.Windows.Forms.Padding(0);
            this.cboxTopping2.Name = "cboxTopping2";
            this.cboxTopping2.Size = new System.Drawing.Size(210, 30);
            this.cboxTopping2.TabIndex = 1;
            this.cboxTopping2.Text = "감자 (1EA 200원)";
            this.cboxTopping2.UseVisualStyleBackColor = true;
            // 
            // cboxTopping3
            // 
            this.cboxTopping3.AutoSize = true;
            this.cboxTopping3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxTopping3.Location = new System.Drawing.Point(0, 60);
            this.cboxTopping3.Margin = new System.Windows.Forms.Padding(0);
            this.cboxTopping3.Name = "cboxTopping3";
            this.cboxTopping3.Size = new System.Drawing.Size(210, 32);
            this.cboxTopping3.TabIndex = 2;
            this.cboxTopping3.Text = "치즈 (1EA 300원)";
            this.cboxTopping3.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(314, 274);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lboxOrder
            // 
            this.lboxOrder.FormattingEnabled = true;
            this.lboxOrder.ItemHeight = 15;
            this.lboxOrder.Location = new System.Drawing.Point(12, 314);
            this.lboxOrder.Name = "lboxOrder";
            this.lboxOrder.Size = new System.Drawing.Size(377, 289);
            this.lboxOrder.TabIndex = 4;
            // 
            // numEA
            // 
            this.numEA.Location = new System.Drawing.Point(260, 82);
            this.numEA.Name = "numEA";
            this.numEA.Size = new System.Drawing.Size(69, 25);
            this.numEA.TabIndex = 3;
            this.numEA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "(EA)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 612);
            this.Controls.Add(this.lboxOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbtnDow1;
        private System.Windows.Forms.RadioButton rbtnDow2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbtnEdge1;
        private System.Windows.Forms.RadioButton rbtnEdge2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox cboxTopping1;
        private System.Windows.Forms.CheckBox cboxTopping2;
        private System.Windows.Forms.CheckBox cboxTopping3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lboxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEA;
    }
}

