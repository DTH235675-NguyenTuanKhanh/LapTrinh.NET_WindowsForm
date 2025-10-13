namespace Bai3b
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
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstWeb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(263, 46);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(253, 111);
            this.txtKq.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(152, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(71, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liên Kết Web:";
            // 
            // lstWeb
            // 
            this.lstWeb.FormattingEnabled = true;
            this.lstWeb.ItemHeight = 16;
            this.lstWeb.Location = new System.Drawing.Point(71, 58);
            this.lstWeb.Name = "lstWeb";
            this.lstWeb.Size = new System.Drawing.Size(156, 68);
            this.lstWeb.TabIndex = 11;
            this.lstWeb.SelectedIndexChanged += new System.EventHandler(this.lstWeb_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 196);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstWeb;
    }
}

