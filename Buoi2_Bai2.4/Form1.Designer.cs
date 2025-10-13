namespace Buoi2_Bai2._4
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.Location = new System.Drawing.Point(203, 138);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(133, 28);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "Ho Ten";
            this.lbHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(334, 140);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(283, 22);
            this.txthoten.TabIndex = 4;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(183, 234);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(419, 79);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "HienThi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.btnHienThi);
            this.Name = "Form1";
            this.Text = "Bai2.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button btnHienThi;
    }
}

