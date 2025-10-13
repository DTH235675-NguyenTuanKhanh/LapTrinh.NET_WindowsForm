namespace Bai8
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
            this.cbt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbt
            // 
            this.cbt.FormattingEnabled = true;
            this.cbt.Location = new System.Drawing.Point(184, 89);
            this.cbt.Name = "cbt";
            this.cbt.Size = new System.Drawing.Size(244, 24);
            this.cbt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // btnht
            // 
            this.btnht.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnht.Location = new System.Drawing.Point(175, 153);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(168, 54);
            this.btnht.TabIndex = 2;
            this.btnht.Text = "Hiển thị lời chào";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 255);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnht;
    }
}