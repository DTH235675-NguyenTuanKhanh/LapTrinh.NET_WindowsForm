namespace Bai5._1
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKq = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNho = new System.Windows.Forms.LinkLabel();
            this.lblKetqua = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(289, 83);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(302, 22);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập N:";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKq.Location = new System.Drawing.Point(131, 138);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(136, 25);
            this.lblKq.TabIndex = 3;
            this.lblKq.Text = "Kiểm tra SNT:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(75, 204);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(192, 25);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Tìm SNT nhỏ hơn N:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Làm lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(406, 254);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(180, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kiểm tra và tìm SNT";
            // 
            // lblNho
            // 
            this.lblNho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNho.LinkColor = System.Drawing.Color.Black;
            this.lblNho.Location = new System.Drawing.Point(289, 205);
            this.lblNho.Name = "lblNho";
            this.lblNho.Size = new System.Drawing.Size(302, 24);
            this.lblNho.TabIndex = 10;
            this.lblNho.UseMnemonic = false;
            // 
            // lblKetqua
            // 
            this.lblKetqua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKetqua.LinkColor = System.Drawing.Color.Black;
            this.lblKetqua.Location = new System.Drawing.Point(289, 138);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(302, 24);
            this.lblKetqua.TabIndex = 11;
            this.lblKetqua.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 342);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.lblNho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblNho;
        private System.Windows.Forms.LinkLabel lblKetqua;
    }
}

