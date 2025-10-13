namespace Bai1
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSHH = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnTBMang = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnDemSoChan = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(12, 25);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(139, 39);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 phần tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(170, 25);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(146, 39);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(331, 25);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(142, 39);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(495, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 39);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(657, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXGiam.Location = new System.Drawing.Point(657, 93);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(131, 39);
            this.btnSXGiam.TabIndex = 6;
            this.btnSXGiam.Text = "Sắp xếp giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXTang.Location = new System.Drawing.Point(657, 166);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(131, 39);
            this.btnSXTang.TabIndex = 7;
            this.btnSXTang.Text = "Sắp xếp tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(657, 244);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(115, 39);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "Tổng mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(657, 315);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(115, 39);
            this.btnMax.TabIndex = 9;
            this.btnMax.Text = "Số lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSHH
            // 
            this.btnSHH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHH.Location = new System.Drawing.Point(467, 244);
            this.btnSHH.Name = "btnSHH";
            this.btnSHH.Size = new System.Drawing.Size(167, 39);
            this.btnSHH.TabIndex = 10;
            this.btnSHH.Text = "Số hoàn hảo";
            this.btnSHH.UseVisualStyleBackColor = true;
            this.btnSHH.Click += new System.EventHandler(this.btnSHH_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(467, 315);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(167, 39);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "Số nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoNguyenTo.Location = new System.Drawing.Point(281, 244);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(167, 39);
            this.btnSoNguyenTo.TabIndex = 12;
            this.btnSoNguyenTo.Text = "Số nguyên tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnTBMang
            // 
            this.btnTBMang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBMang.Location = new System.Drawing.Point(281, 315);
            this.btnTBMang.Name = "btnTBMang";
            this.btnTBMang.Size = new System.Drawing.Size(167, 39);
            this.btnTBMang.TabIndex = 13;
            this.btnTBMang.Text = "Trung bình mảng";
            this.btnTBMang.UseVisualStyleBackColor = true;
            this.btnTBMang.Click += new System.EventHandler(this.btnTBMang_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoLe.Location = new System.Drawing.Point(158, 244);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(108, 39);
            this.btnDemSoLe.TabIndex = 14;
            this.btnDemSoLe.Text = "Đếm số lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCLN.Location = new System.Drawing.Point(30, 315);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(236, 39);
            this.btnUCLN.TabIndex = 15;
            this.btnUCLN.Text = "UCLN của 2 phần tử đầu tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // btnDemSoChan
            // 
            this.btnDemSoChan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoChan.Location = new System.Drawing.Point(28, 244);
            this.btnDemSoChan.Name = "btnDemSoChan";
            this.btnDemSoChan.Size = new System.Drawing.Size(123, 39);
            this.btnDemSoChan.TabIndex = 16;
            this.btnDemSoChan.Text = "Đếm số chẳn ";
            this.btnDemSoChan.UseVisualStyleBackColor = true;
            this.btnDemSoChan.Click += new System.EventHandler(this.btnDemSoChan_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.LightSalmon;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.LinkColor = System.Drawing.Color.Black;
            this.lblKQ.Location = new System.Drawing.Point(25, 93);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(609, 121);
            this.lblKQ.TabIndex = 17;
            this.lblKQ.TabStop = true;
            this.lblKQ.Text = "Các phần tử trong mảng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnDemSoChan);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnTBMang);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSHH);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSXGiam;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSHH;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSoNguyenTo;
        private System.Windows.Forms.Button btnTBMang;
        private System.Windows.Forms.Button btnDemSoLe;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Button btnDemSoChan;
        private System.Windows.Forms.LinkLabel lblKQ;
    }
}

