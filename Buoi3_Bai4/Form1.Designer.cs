namespace Bai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChuHoa = new System.Windows.Forms.RadioButton();
            this.rdoChuthuong = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnKQ = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(113, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChuHoa);
            this.groupBox1.Controls.Add(this.rdoChuthuong);
            this.groupBox1.Location = new System.Drawing.Point(118, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rdoChuHoa
            // 
            this.rdoChuHoa.AutoSize = true;
            this.rdoChuHoa.Location = new System.Drawing.Point(26, 68);
            this.rdoChuHoa.Name = "rdoChuHoa";
            this.rdoChuHoa.Size = new System.Drawing.Size(144, 29);
            this.rdoChuHoa.TabIndex = 2;
            this.rdoChuHoa.TabStop = true;
            this.rdoChuHoa.Text = "CHỮ HOA";
            this.rdoChuHoa.UseVisualStyleBackColor = true;
            // 
            // rdoChuthuong
            // 
            this.rdoChuthuong.AutoSize = true;
            this.rdoChuthuong.Location = new System.Drawing.Point(26, 33);
            this.rdoChuthuong.Name = "rdoChuthuong";
            this.rdoChuthuong.Size = new System.Drawing.Size(156, 29);
            this.rdoChuthuong.TabIndex = 0;
            this.rdoChuthuong.TabStop = true;
            this.rdoChuthuong.Text = "Chữ thường";
            this.rdoChuthuong.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(264, 37);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(325, 34);
            this.txtHoten.TabIndex = 0;
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(118, 232);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(134, 43);
            this.btnKQ.TabIndex = 3;
            this.btnKQ.Text = "Kết Quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(481, 103);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(481, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 45);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(264, 238);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(325, 34);
            this.txtKq.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 311);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChuHoa;
        private System.Windows.Forms.RadioButton rdoChuthuong;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtKq;
    }
}

