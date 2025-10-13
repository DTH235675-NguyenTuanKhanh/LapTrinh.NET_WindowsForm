namespace Bai3
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnTaomang = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(408, 92);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 50);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSum
            // 
            this.btnSum.Enabled = false;
            this.btnSum.Location = new System.Drawing.Point(55, 92);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(150, 50);
            this.btnSum.TabIndex = 10;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnTaomang
            // 
            this.btnTaomang.Location = new System.Drawing.Point(408, 30);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(155, 31);
            this.btnTaomang.TabIndex = 9;
            this.btnTaomang.Text = "Tạo mảng Random";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(267, 30);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(120, 26);
            this.txtNhap.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số phần tử mảng:";
            // 
            // btnMax
            // 
            this.btnMax.Enabled = false;
            this.btnMax.Location = new System.Drawing.Point(234, 92);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(153, 50);
            this.btnMax.TabIndex = 12;
            this.btnMax.Text = "Số lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 175);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMax;
    }
}

