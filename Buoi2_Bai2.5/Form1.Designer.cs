namespace Buoi2_Bai2._5
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
            this.lbPHEPTOAN = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.lbb = new System.Windows.Forms.Label();
            this.lba = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPHEPTOAN
            // 
            this.lbPHEPTOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPHEPTOAN.Location = new System.Drawing.Point(272, 34);
            this.lbPHEPTOAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPHEPTOAN.Name = "lbPHEPTOAN";
            this.lbPHEPTOAN.Size = new System.Drawing.Size(256, 54);
            this.lbPHEPTOAN.TabIndex = 8;
            this.lbPHEPTOAN.Text = "PHEP TOAN";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(313, 344);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(199, 73);
            this.btnTong.TabIndex = 7;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.lbb);
            this.groupBox1.Controls.Add(this.lba);
            this.groupBox1.Location = new System.Drawing.Point(279, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 143);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(87, 82);
            this.txtb.Margin = new System.Windows.Forms.Padding(4);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(132, 22);
            this.txtb.TabIndex = 17;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(87, 39);
            this.txta.Margin = new System.Windows.Forms.Padding(4);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(132, 22);
            this.txta.TabIndex = 16;
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(30, 82);
            this.lbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(15, 16);
            this.lbb.TabIndex = 15;
            this.lbb.Text = "b";
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(30, 39);
            this.lba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(15, 16);
            this.lba.TabIndex = 14;
            this.lba.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbPHEPTOAN);
            this.Controls.Add(this.btnTong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPHEPTOAN;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lba;
    }
}

