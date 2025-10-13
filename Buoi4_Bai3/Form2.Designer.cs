namespace Bai3
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
            this.lblKQ = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.SystemColors.Control;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.Blue;
            this.lblKQ.LinkColor = System.Drawing.Color.Blue;
            this.lblKQ.Location = new System.Drawing.Point(61, 174);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(191, 46);
            this.lblKQ.TabIndex = 9;
            this.lblKQ.TabStop = true;
            this.lblKQ.Text = "linkLabel1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblKQ;
    }
}