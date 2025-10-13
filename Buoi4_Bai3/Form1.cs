using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;
        //phuong thuc tao mang
        public void TaoMang(int n)
        {
            //khai báo mảng có n phần tử nhập từ Textbox
            a = new int[n];
            //khởi tạo giá tri ngẫu nhiên cho mảng
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                //tạo số ngẫu nhiên nằm giữa so1 và so2
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }


        private void btnTaomang_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text=="")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng","Thông báo");
                txtNhap.Focus();
                return;
            }
            n = Convert.ToInt32(txtNhap.Text);
            if(n<=0)
            {
                MessageBox.Show("Số phần tử mảng phải lớn hơn 0","Thông báo");
                txtNhap.Focus();
                return;
            }
            TaoMang(n);
            MessageBox.Show("Mảng đã tạo: "+ string.Join(" ",a), "Thông báo");
            btnSum.Enabled = true;
            btnMax.Enabled = true;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tính tổng các phần tử trong mảng không?", "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) 
            {
                Form2 f2 = new Form2(a);
                f2.ShowDialog();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tìm phần tử lớn nhất trong mảng không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form3 f3 = new Form3(a);
                f3.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
