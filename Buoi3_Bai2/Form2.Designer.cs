namespace Bai2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNho = new System.Windows.Forms.CheckBox();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(282, 155);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(245, 22);
            this.txtPass.TabIndex = 16;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(282, 103);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(245, 22);
            this.txtUser.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // chkNho
            // 
            this.chkNho.Location = new System.Drawing.Point(74, 194);
            this.chkNho.Name = "chkNho";
            this.chkNho.Size = new System.Drawing.Size(137, 39);
            this.chkNho.TabIndex = 12;
            this.chkNho.Text = "Ghi nhớ";
            this.chkNho.UseVisualStyleBackColor = true;
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(440, 292);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(178, 55);
            this.btnDung.TabIndex = 11;
            this.btnDung.Text = "Thoát";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(117, 292);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(178, 55);
            this.btnDangnhap.TabIndex = 9;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thông tin đăng nhập";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNho);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnDangnhap);
            this.Name = "Form2";
            this.Text = "Đăng Nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNho;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
    }
}