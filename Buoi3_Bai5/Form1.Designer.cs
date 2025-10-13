namespace Bai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập m:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(177, 68);
            this.txtn.Multiline = true;
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(133, 45);
            this.txtn.TabIndex = 2;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(177, 138);
            this.txtm.Multiline = true;
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(133, 45);
            this.txtm.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo2);
            this.groupBox1.Controls.Add(this.rdo1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(356, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(45, 50);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(306, 30);
            this.rdo1.TabIndex = 0;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Các ước số chung của n và m";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(45, 108);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(326, 30);
            this.rdo2.TabIndex = 1;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Ước chung lớn nhất của n và m";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả là:";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(37, 292);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(709, 37);
            this.txtKq.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(90, 359);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(140, 53);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(316, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 53);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(567, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 53);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lệnh lặp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

