using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "") || (this.txtPass.Text == ""))
                {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Thông báo");
            }
            else
            {
                if ((this.txtUser.Text == "nguyentuankhanh") || (this.txtPass.Text == "301108"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo");
                    this.txtUser.Clear();
                    this.txtPass.Clear();
                    this.txtUser.Focus();
                }
            }    

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
