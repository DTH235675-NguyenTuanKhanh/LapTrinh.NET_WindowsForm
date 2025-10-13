namespace Bai6
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.ltbTen = new System.Windows.Forms.ListBox();
            this.btnChu = new System.Windows.Forms.Button();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(24, 29);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(257, 30);
            this.txtNhap.TabIndex = 0;
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.Location = new System.Drawing.Point(361, 25);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(534, 194);
            this.txtKq.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(25, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(203, 137);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ltbTen
            // 
            this.ltbTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbTen.FormattingEnabled = true;
            this.ltbTen.ItemHeight = 26;
            this.ltbTen.Location = new System.Drawing.Point(25, 204);
            this.ltbTen.Name = "ltbTen";
            this.ltbTen.Size = new System.Drawing.Size(308, 186);
            this.ltbTen.TabIndex = 4;
            this.ltbTen.SelectedIndexChanged += new System.EventHandler(this.ltbTen_SelectedIndexChanged);
            // 
            // btnChu
            // 
            this.btnChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChu.Location = new System.Drawing.Point(361, 247);
            this.btnChu.Name = "btnChu";
            this.btnChu.Size = new System.Drawing.Size(157, 41);
            this.btnChu.TabIndex = 5;
            this.btnChu.Text = "Chọn màu chữ";
            this.btnChu.UseVisualStyleBackColor = true;
            this.btnChu.Click += new System.EventHandler(this.btnChu_Click);
            // 
            // btnNen
            // 
            this.btnNen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNen.Location = new System.Drawing.Point(545, 247);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(157, 41);
            this.btnNen.TabIndex = 6;
            this.btnNen.Text = "Chọn màu nền";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(738, 247);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(157, 41);
            this.btnF.TabIndex = 7;
            this.btnF.Text = "Font";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(529, 329);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(194, 41);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(309, 204);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 186);
            this.vScrollBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.btnChu);
            this.Controls.Add(this.ltbTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox ltbTen;
        private System.Windows.Forms.Button btnChu;
        private System.Windows.Forms.Button btnNen;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

