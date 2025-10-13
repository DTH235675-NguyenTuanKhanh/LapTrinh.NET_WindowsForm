using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.txtNhap.Text!="")
            {
                this.ltbTen.Items.Add(this.txtNhap.Text);
                this.txtKq.Text = txtNhap.Text;
                this.txtNhap.Clear();
                this.txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần thêm");
                this.txtNhap.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.ltbTen.Items.RemoveAt(this.ltbTen.SelectedIndex);
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                this.txtKq.ForeColor = cd.Color;
            }
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.txtKq.BackColor = cd.Color;
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.txtKq.Font = fd.Font;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ltbTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
