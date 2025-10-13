namespace Bai2
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
            this.lblKQ = new System.Windows.Forms.LinkLabel();
            this.btnTaomang = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử mảng:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(246, 20);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(120, 31);
            this.txtNhap.TabIndex = 1;
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.PeachPuff;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKQ.LinkColor = System.Drawing.Color.Black;
            this.lblKQ.Location = new System.Drawing.Point(14, 67);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(528, 88);
            this.lblKQ.TabIndex = 2;
            this.lblKQ.TabStop = true;
            this.lblKQ.Text = "linkLabel1";
            // 
            // btnTaomang
            // 
            this.btnTaomang.Location = new System.Drawing.Point(387, 20);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(155, 31);
            this.btnTaomang.TabIndex = 3;
            this.btnTaomang.Text = "Tạo mảng Random";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Location = new System.Drawing.Point(79, 172);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 50);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(317, 172);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 50);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 244);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.LinkLabel lblKQ;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
    }
}

