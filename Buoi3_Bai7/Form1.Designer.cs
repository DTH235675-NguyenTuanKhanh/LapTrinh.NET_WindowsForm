namespace Bai7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTru = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChia = new System.Windows.Forms.ToolStripMenuItem();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(109, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Tính";
            // 
            // tsmTinh
            // 
            this.tsmTinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCong,
            this.tsmTru,
            this.tsmNhan,
            this.tsmChia});
            this.tsmTinh.Name = "tsmTinh";
            this.tsmTinh.Size = new System.Drawing.Size(51, 24);
            this.tsmTinh.Text = "Tính";
            // 
            // tsmCong
            // 
            this.tsmCong.Name = "tsmCong";
            this.tsmCong.Size = new System.Drawing.Size(224, 26);
            this.tsmCong.Text = "Tổng";
            this.tsmCong.Click += new System.EventHandler(this.tsmCong_Click);
            // 
            // tsmTru
            // 
            this.tsmTru.Name = "tsmTru";
            this.tsmTru.Size = new System.Drawing.Size(224, 26);
            this.tsmTru.Text = "Hiệu";
            this.tsmTru.Click += new System.EventHandler(this.tsmTru_Click);
            // 
            // tsmNhan
            // 
            this.tsmNhan.Name = "tsmNhan";
            this.tsmNhan.Size = new System.Drawing.Size(224, 26);
            this.tsmNhan.Text = "Tích";
            this.tsmNhan.Click += new System.EventHandler(this.tsmNhan_Click);
            // 
            // tsmChia
            // 
            this.tsmChia.Name = "tsmChia";
            this.tsmChia.Size = new System.Drawing.Size(224, 26);
            this.tsmChia.Text = "Thương";
            this.tsmChia.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(117, 52);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(223, 44);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(117, 134);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(223, 44);
            this.txtb.TabIndex = 2;
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.Location = new System.Drawing.Point(186, 328);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(223, 44);
            this.txtKq.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Phép toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTinh;
        private System.Windows.Forms.ToolStripMenuItem tsmCong;
        private System.Windows.Forms.ToolStripMenuItem tsmTru;
        private System.Windows.Forms.ToolStripMenuItem tsmNhan;
        private System.Windows.Forms.ToolStripMenuItem tsmChia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label label3;
    }
}

