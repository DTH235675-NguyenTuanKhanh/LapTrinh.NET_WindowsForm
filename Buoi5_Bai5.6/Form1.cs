using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr;
        Random rdm = new Random();

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhapmang.Text))
            {
                try
                {
                    arr = txtNhapmang.Text
                  .Trim()
                  .Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
                    txtKQ.Text = string.Join(" ", arr);
                }
                catch
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ!");
                    return;
                }
            }
        }

        private void btnTongchan_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tong = arr.Where(x => x % 2 == 0).Sum();
            txtKQ.Text = "Tổng chẵn = " + tong.ToString();
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int dem = arr.Count(x => x % 2 != 0);
            txtKQ.Text = "Số phần tử lẻ = " + dem.ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tong = arr.Where(x => x % 2 != 0).Sum();
            txtKQ.Text = "Tổng lẻ = " + tong.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int min = arr.Min();
            txtKQ.Text = "Giá trị nhỏ nhất = " + min.ToString();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            var lietke = arr.Where(x => x % 2 == 0).ToArray();
            txtKQ.Text = "Các phần tử chẳn: " + string.Join(" ",lietke);
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int dem= arr.Count(x => x % 2 == 0);
            txtKQ.Text = "Số phần tử chẵn = " + dem.ToString();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int chancuoi = -1;
            for(int i=arr.Length-1;i>=0;i--)
            {
                if(arr[i] % 2 == 0)
                {
                    chancuoi = arr[i];
                    break;
                }
            }
            if (chancuoi == -1)
                txtKQ.Text = "Mảng không có số chẵn";
            else
                txtKQ.Text = "Số chẵn cuối cùng = " + chancuoi.ToString();
        }
    }
}
