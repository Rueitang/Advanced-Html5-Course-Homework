namespace MovieTicketSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studentDiscount = new System.Windows.Forms.ComboBox();
            this.childrenDiscount = new System.Windows.Forms.ComboBox();
            this.vipDiscount = new System.Windows.Forms.ComboBox();
            this.ticketKind = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "加入清單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 186);
            this.textBox1.TabIndex = 6;
            // 
            // studentDiscount
            // 
            this.studentDiscount.FormattingEnabled = true;
            this.studentDiscount.Items.AddRange(new object[] {
            "憑學生證可享受票價8折優惠"});
            this.studentDiscount.Location = new System.Drawing.Point(24, 27);
            this.studentDiscount.Name = "studentDiscount";
            this.studentDiscount.Size = new System.Drawing.Size(121, 20);
            this.studentDiscount.TabIndex = 7;
            this.studentDiscount.Text = "學生票折扣方式";
            this.studentDiscount.Enter += new System.EventHandler(this.studentDiscount_Enter);
            // 
            // childrenDiscount
            // 
            this.childrenDiscount.FormattingEnabled = true;
            this.childrenDiscount.Items.AddRange(new object[] {
            "在10周歲及以下的兒童3折",
            "小學生與屁孩7折優惠"});
            this.childrenDiscount.Location = new System.Drawing.Point(151, 27);
            this.childrenDiscount.Name = "childrenDiscount";
            this.childrenDiscount.Size = new System.Drawing.Size(121, 20);
            this.childrenDiscount.TabIndex = 8;
            this.childrenDiscount.Text = "屁孩折扣方式";
            this.childrenDiscount.Enter += new System.EventHandler(this.childrenDiscount_Enter);
            // 
            // vipDiscount
            // 
            this.vipDiscount.FormattingEnabled = true;
            this.vipDiscount.Items.AddRange(new object[] {
            "持花旗卡可以半價"});
            this.vipDiscount.Location = new System.Drawing.Point(279, 27);
            this.vipDiscount.Name = "vipDiscount";
            this.vipDiscount.Size = new System.Drawing.Size(121, 20);
            this.vipDiscount.TabIndex = 9;
            this.vipDiscount.Text = "信用卡折扣方式";
            this.vipDiscount.Enter += new System.EventHandler(this.vipDiscount_Enter);
            // 
            // ticketKind
            // 
            this.ticketKind.FormattingEnabled = true;
            this.ticketKind.Items.AddRange(new object[] {
            "學生票",
            "兒童票",
            "全票"});
            this.ticketKind.Location = new System.Drawing.Point(24, 75);
            this.ticketKind.Name = "ticketKind";
            this.ticketKind.Size = new System.Drawing.Size(121, 20);
            this.ticketKind.TabIndex = 10;
            this.ticketKind.Text = "學生票";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "張數";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 436);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ticketKind);
            this.Controls.Add(this.vipDiscount);
            this.Controls.Add(this.childrenDiscount);
            this.Controls.Add(this.studentDiscount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox studentDiscount;
        private System.Windows.Forms.ComboBox childrenDiscount;
        private System.Windows.Forms.ComboBox vipDiscount;
        private System.Windows.Forms.ComboBox ticketKind;
        private System.Windows.Forms.TextBox textBox2;
    }
}

