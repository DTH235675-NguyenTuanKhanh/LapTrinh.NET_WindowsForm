using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtNhap.Text.Trim();
            if(ten=="")
            {
                MessageBox.Show("Vui lòng nhập tên");
                txtNhap.Focus();
                return;
            }
            if (rdoA.Checked)
                lbA.Items.Add(ten);
            else if (rdoB.Checked)
                lbA.Items.Add(ten);
            else
            {
                MessageBox.Show("Vui lòng chọn lớp","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                rdoA.Focus();
                return;
            }
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            while(lbB.SelectedItems.Count>0)
            {
                lbA.Items.Add(lbB.SelectedItems[0]);
                lbB.Items.Remove(lbB.SelectedItems[0]);
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            while (lbA.SelectedItems.Count > 0)
            {
                lbB.Items.Add(lbA.SelectedItems[0]);
                lbA.Items.Remove(lbA.SelectedItems[0]);
            }
        }

        private void btnHetTrai_Click(object sender, EventArgs e)
        {
            foreach(var item in lbB.Items)
                lbA.Items.Add(item);
            lbB.Items.Clear();
        }

        private void btnHetPhai_Click(object sender, EventArgs e)
        {
            foreach (var item in lbA.Items)
                lbB.Items.Add(item);
            lbA.Items.Clear();
            
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tongA = lbA.Items.Count;
            int tongB = lbB.Items.Count;
            int tong = tongA + tongB;
            MessageBox.Show($"Tổng số sinh viên:\nLớp A: {tongA}\nLớp B: {tongB}\nTổng cộng: {tong}",
                "Thống kê sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
