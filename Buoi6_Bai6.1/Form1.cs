using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.Title = "Chon File de mo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbNhap.Text = System.IO.File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi mo file: " + ex.Message);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.Title = "Chon File de luu";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(sfd.FileName, rtbNhap.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi luu file: " + ex.Message);
                }
            }

        }

        private void btnf_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtbNhap.Font = fd.Font;
            }
        }

        private void btnmau_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtbNhap.ForeColor = cd.Color;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
