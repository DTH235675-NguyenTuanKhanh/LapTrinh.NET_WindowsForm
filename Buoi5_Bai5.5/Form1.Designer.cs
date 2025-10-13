namespace Bai5._5
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
            this.txtNhapmang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapmang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng Gốc";
            // 
            // txtNhapmang
            // 
            this.txtNhapmang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapmang.Location = new System.Drawing.Point(18, 31);
            this.txtNhapmang.Name = "txtNhapmang";
            this.txtNhapmang.Size = new System.Drawing.Size(740, 38);
            this.txtNhapmang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKQ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(18, 31);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(740, 38);
            this.txtKQ.TabIndex = 0;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(12, 196);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(368, 42);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(12, 258);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(368, 42);
            this.btnTong.TabIndex = 3;
            this.btnTong.Text = "Tổng mảng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnDemLe
            // 
            this.btnDemLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemLe.Location = new System.Drawing.Point(12, 319);
            this.btnDemLe.Name = "btnDemLe";
            this.btnDemLe.Size = new System.Drawing.Size(368, 42);
            this.btnDemLe.TabIndex = 4;
            this.btnDemLe.Text = "Đếm số phần tử lẻ";
            this.btnDemLe.UseVisualStyleBackColor = true;
            this.btnDemLe.Click += new System.EventHandler(this.btnDemLe_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongLe.Location = new System.Drawing.Point(12, 382);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(368, 42);
            this.btnTongLe.TabIndex = 5;
            this.btnTongLe.Text = "Tổng các phần tử lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam.Location = new System.Drawing.Point(420, 382);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(368, 42);
            this.btnGiam.TabIndex = 9;
            this.btnGiam.Text = "Sắp xếp các phần tử giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang.Location = new System.Drawing.Point(420, 319);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(368, 42);
            this.btnTang.TabIndex = 8;
            this.btnTang.Text = "Sắp xếp phần tử tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang2.Location = new System.Drawing.Point(420, 258);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(368, 42);
            this.btnTang2.TabIndex = 7;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(420, 196);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(368, 42);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapmang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnMin;
    }
}

