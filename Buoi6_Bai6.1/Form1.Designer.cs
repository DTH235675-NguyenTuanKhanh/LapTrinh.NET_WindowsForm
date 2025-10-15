namespace Buoi6_Bai6._1
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
            this.rtbNhap = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnf = new System.Windows.Forms.Button();
            this.btnmau = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbNhap
            // 
            this.rtbNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbNhap.Location = new System.Drawing.Point(23, 51);
            this.rtbNhap.Name = "rtbNhap";
            this.rtbNhap.Size = new System.Drawing.Size(615, 261);
            this.rtbNhap.TabIndex = 0;
            this.rtbNhap.Text = "";
            this.rtbNhap.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập đoạn văn bản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnf
            // 
            this.btnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf.Location = new System.Drawing.Point(23, 329);
            this.btnf.Name = "btnf";
            this.btnf.Size = new System.Drawing.Size(130, 41);
            this.btnf.TabIndex = 2;
            this.btnf.Text = "Chọn font";
            this.btnf.UseVisualStyleBackColor = true;
            this.btnf.Click += new System.EventHandler(this.btnf_Click);
            // 
            // btnmau
            // 
            this.btnmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmau.Location = new System.Drawing.Point(183, 329);
            this.btnmau.Name = "btnmau";
            this.btnmau.Size = new System.Drawing.Size(130, 41);
            this.btnmau.TabIndex = 3;
            this.btnmau.Text = "Chọn màu";
            this.btnmau.UseVisualStyleBackColor = true;
            this.btnmau.Click += new System.EventHandler(this.btnmau_Click);
            // 
            // btnMo
            // 
            this.btnMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.Location = new System.Drawing.Point(345, 329);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(130, 41);
            this.btnMo.TabIndex = 4;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(508, 329);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(130, 41);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(238, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(179, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.btnmau);
            this.Controls.Add(this.btnf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnf;
        private System.Windows.Forms.Button btnmau;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnThoat;
    }
}

