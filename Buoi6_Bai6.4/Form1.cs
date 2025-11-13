using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvThongtin.View = View.Details;
            lvThongtin.FullRowSelect = true;
            lvThongtin.GridLines = true;
            lvThongtin.Columns.Add("Mã SV", 80);
            lvThongtin.Columns.Add("Họ tên", 100);
            lvThongtin.Columns.Add("Ngày sinh", 100);
            lvThongtin.Columns.Add("Số điện thoại", 100);
            lvThongtin.Columns.Add("Giới tính", 70);
            lvThongtin.Columns.Add("Quê quán", 100);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên không được trống!", "Lỗi");
                return;
            }
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(dtpBD.Value.ToShortDateString());
            item.SubItems.Add(rdoNam.Checked ? "Nam" : "nữ");
            item.SubItems.Add(txtSĐT.Text);
            item.SubItems.Add(cmbQue.Text);

            lvThongtin.Items.Add(item);
        }
    }
}
