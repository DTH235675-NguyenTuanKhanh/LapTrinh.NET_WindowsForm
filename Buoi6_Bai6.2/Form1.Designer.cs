namespace Buoi6_Bai6._2
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
            this.btnthem = new System.Windows.Forms.Button();
            this.grpChon = new System.Windows.Forms.GroupBox();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.grpA = new System.Windows.Forms.GroupBox();
            this.lbA = new System.Windows.Forms.ListBox();
            this.grpB = new System.Windows.Forms.GroupBox();
            this.lbB = new System.Windows.Forms.ListBox();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnHetTrai = new System.Windows.Forms.Button();
            this.btnHetPhai = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpChon.SuspendLayout();
            this.grpA.SuspendLayout();
            this.grpB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNhap.Location = new System.Drawing.Point(117, 20);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(491, 34);
            this.txtNhap.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(627, 15);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(151, 47);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.rdoB);
            this.grpChon.Controls.Add(this.rdoA);
            this.grpChon.Location = new System.Drawing.Point(247, 88);
            this.grpChon.Name = "grpChon";
            this.grpChon.Size = new System.Drawing.Size(311, 100);
            this.grpChon.TabIndex = 3;
            this.grpChon.TabStop = false;
            this.grpChon.Text = "Chọn lớp";
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoA.Location = new System.Drawing.Point(34, 38);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(85, 29);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "Lớp A";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoB.Location = new System.Drawing.Point(179, 38);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(84, 29);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "Lớp B";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // grpA
            // 
            this.grpA.Controls.Add(this.lbA);
            this.grpA.Location = new System.Drawing.Point(40, 196);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(293, 213);
            this.grpA.TabIndex = 4;
            this.grpA.TabStop = false;
            this.grpA.Text = "Lớp A";
            // 
            // lbA
            // 
            this.lbA.FormattingEnabled = true;
            this.lbA.ItemHeight = 16;
            this.lbA.Location = new System.Drawing.Point(6, 21);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(281, 164);
            this.lbA.TabIndex = 5;
            // 
            // grpB
            // 
            this.grpB.Controls.Add(this.lbB);
            this.grpB.Location = new System.Drawing.Point(470, 196);
            this.grpB.Name = "grpB";
            this.grpB.Size = new System.Drawing.Size(293, 213);
            this.grpB.TabIndex = 5;
            this.grpB.TabStop = false;
            this.grpB.Text = "Lớp B";
            // 
            // lbB
            // 
            this.lbB.FormattingEnabled = true;
            this.lbB.ItemHeight = 16;
            this.lbB.Location = new System.Drawing.Point(6, 21);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(281, 164);
            this.lbB.TabIndex = 5;
            // 
            // btnTrai
            // 
            this.btnTrai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrai.Location = new System.Drawing.Point(339, 196);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(125, 39);
            this.btnTrai.TabIndex = 6;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhai.Location = new System.Drawing.Point(339, 253);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(125, 39);
            this.btnPhai.TabIndex = 7;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnHetTrai
            // 
            this.btnHetTrai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHetTrai.Location = new System.Drawing.Point(339, 312);
            this.btnHetTrai.Name = "btnHetTrai";
            this.btnHetTrai.Size = new System.Drawing.Size(125, 39);
            this.btnHetTrai.TabIndex = 8;
            this.btnHetTrai.Text = "<<";
            this.btnHetTrai.UseVisualStyleBackColor = true;
            this.btnHetTrai.Click += new System.EventHandler(this.btnHetTrai_Click);
            // 
            // btnHetPhai
            // 
            this.btnHetPhai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHetPhai.Location = new System.Drawing.Point(339, 370);
            this.btnHetPhai.Name = "btnHetPhai";
            this.btnHetPhai.Size = new System.Drawing.Size(125, 39);
            this.btnHetPhai.TabIndex = 9;
            this.btnHetPhai.Text = ">>";
            this.btnHetPhai.UseVisualStyleBackColor = true;
            this.btnHetPhai.Click += new System.EventHandler(this.btnHetPhai_Click);
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(162, 432);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(211, 56);
            this.btnTong.TabIndex = 10;
            this.btnTong.Text = "Tổng số sinh viên";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(424, 432);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(184, 56);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnHetPhai);
            this.Controls.Add(this.btnHetTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.grpB);
            this.Controls.Add(this.grpA);
            this.Controls.Add(this.grpChon);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpChon.ResumeLayout(false);
            this.grpChon.PerformLayout();
            this.grpA.ResumeLayout(false);
            this.grpB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox grpChon;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.GroupBox grpA;
        private System.Windows.Forms.ListBox lbA;
        private System.Windows.Forms.GroupBox grpB;
        private System.Windows.Forms.ListBox lbB;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnHetTrai;
        private System.Windows.Forms.Button btnHetPhai;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnThoat;
    }
}

