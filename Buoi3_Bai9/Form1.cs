using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string hoten = txtTen.Text;
            string gioitinh = rdbNam.Checked ? "Nam" : "Nữ";
            int dienthoai = int.Parse(txtDt.Text);
            string email = txtE.Text;
            string ngaysinh = dtpNs.Value.ToString("dd/MM/yyyy");
            string diachi = txtDc.Text;
            string tinhtrang = cbHoc.Checked ? "Đang đi học" : "Đang đi làm";
            MessageBox.Show("Họ tên: " + hoten + "\nGiới tính: " + gioitinh + "\nĐịa chỉ: " + diachi + "\nĐiện thoại: " + dienthoai + "\nEmail: " + email + "\nTình trạng: " + tinhtrang);

        }
    }
}
