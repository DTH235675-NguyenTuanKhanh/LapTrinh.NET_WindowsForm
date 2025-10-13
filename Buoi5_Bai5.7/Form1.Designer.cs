namespace Bai5._7
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpTong = new System.Windows.Forms.GroupBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grpTim = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.grpSX = new System.Windows.Forms.GroupBox();
            this.btnSX = new System.Windows.Forms.Button();
            this.rdoTang = new System.Windows.Forms.RadioButton();
            this.rdoGiam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTT = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpTong.SuspendLayout();
            this.grpTim.SuspendLayout();
            this.grpSX.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mảng: ";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(159, 63);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(440, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(159, 118);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(440, 30);
            this.txtKQ.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(249, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "MẢNG SỐ NGUYÊN";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(631, 55);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(157, 47);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất mảng";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(631, 108);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 47);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Làm lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpTong
            // 
            this.grpTong.Controls.Add(this.btnTong);
            this.grpTong.Controls.Add(this.label6);
            this.grpTong.Controls.Add(this.txtTL);
            this.grpTong.Controls.Add(this.label5);
            this.grpTong.Controls.Add(this.txtTong);
            this.grpTong.Controls.Add(this.txtTC);
            this.grpTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTong.Location = new System.Drawing.Point(48, 189);
            this.grpTong.Name = "grpTong";
            this.grpTong.Size = new System.Drawing.Size(327, 162);
            this.grpTong.TabIndex = 7;
            this.grpTong.TabStop = false;
            this.grpTong.Text = "Tổng";
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(134, 33);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(85, 27);
            this.txtTong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(60, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng chẵn: ";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.Location = new System.Drawing.Point(134, 77);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(85, 27);
            this.txtTC.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(14, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng lẻ: ";
            // 
            // txtTL
            // 
            this.txtTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.Location = new System.Drawing.Point(134, 121);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(85, 27);
            this.txtTL.TabIndex = 11;
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(237, 36);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 111);
            this.btnTong.TabIndex = 12;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(442, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min: ";
            // 
            // grpTim
            // 
            this.grpTim.Controls.Add(this.btnTim);
            this.grpTim.Controls.Add(this.label9);
            this.grpTim.Controls.Add(this.txtMin);
            this.grpTim.Controls.Add(this.txtMax);
            this.grpTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTim.Location = new System.Drawing.Point(430, 189);
            this.grpTim.Name = "grpTim";
            this.grpTim.Size = new System.Drawing.Size(327, 162);
            this.grpTim.TabIndex = 9;
            this.grpTim.TabStop = false;
            this.grpTim.Text = "Tìm Min Max";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(237, 36);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 111);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Max: ";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(111, 33);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(108, 27);
            this.txtMin.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(111, 77);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(108, 27);
            this.txtMax.TabIndex = 9;
            // 
            // grpSX
            // 
            this.grpSX.Controls.Add(this.rdoGiam);
            this.grpSX.Controls.Add(this.rdoTang);
            this.grpSX.Controls.Add(this.btnSX);
            this.grpSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSX.Location = new System.Drawing.Point(48, 372);
            this.grpSX.Name = "grpSX";
            this.grpSX.Size = new System.Drawing.Size(327, 131);
            this.grpSX.TabIndex = 11;
            this.grpSX.TabStop = false;
            this.grpSX.Text = "Sắp xếp";
            // 
            // btnSX
            // 
            this.btnSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSX.Location = new System.Drawing.Point(237, 36);
            this.btnSX.Name = "btnSX";
            this.btnSX.Size = new System.Drawing.Size(75, 68);
            this.btnSX.TabIndex = 12;
            this.btnSX.Text = "Sắp xếp";
            this.btnSX.UseVisualStyleBackColor = true;
            this.btnSX.Click += new System.EventHandler(this.btnSX_Click);
            // 
            // rdoTang
            // 
            this.rdoTang.AutoSize = true;
            this.rdoTang.Location = new System.Drawing.Point(29, 36);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new System.Drawing.Size(149, 29);
            this.rdoTang.TabIndex = 12;
            this.rdoTang.TabStop = true;
            this.rdoTang.Text = "Sắp xếp tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            // 
            // rdoGiam
            // 
            this.rdoGiam.AutoSize = true;
            this.rdoGiam.Location = new System.Drawing.Point(29, 75);
            this.rdoGiam.Name = "rdoGiam";
            this.rdoGiam.Size = new System.Drawing.Size(153, 29);
            this.rdoGiam.TabIndex = 13;
            this.rdoGiam.TabStop = true;
            this.rdoGiam.Text = "Sắp xếp giảm";
            this.rdoGiam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(442, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vị trí thay thế: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtVT);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(430, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 131);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Min Max";
            // 
            // btnTT
            // 
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(237, 33);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(75, 71);
            this.btnTT.TabIndex = 12;
            this.btnTT.Text = "Thay thế";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(14, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số thay thế: ";
            // 
            // txtVT
            // 
            this.txtVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVT.Location = new System.Drawing.Point(117, 32);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(108, 27);
            this.txtVT.TabIndex = 5;
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT.Location = new System.Drawing.Point(117, 75);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(108, 27);
            this.txtSTT.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(336, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 39);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpTim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpTong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTong.ResumeLayout(false);
            this.grpTong.PerformLayout();
            this.grpTim.ResumeLayout(false);
            this.grpTim.PerformLayout();
            this.grpSX.ResumeLayout(false);
            this.grpSX.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.GroupBox grpSX;
        private System.Windows.Forms.RadioButton rdoGiam;
        private System.Windows.Forms.RadioButton rdoTang;
        private System.Windows.Forms.Button btnSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnThoat;
    }
}

