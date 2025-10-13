using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._5
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
            if(!string.IsNullOrEmpty(txtNhapmang.Text))
            {
                try
                {
                    arr = txtNhapmang.Text
                  .Trim()
                  .Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
                    int[] tron = (int[])arr.Clone();
                    for(int i=tron.Length-1;i>0;i--)
                    {
                        int j = rdm.Next(i + 1);
                        (tron[i], tron[j]) = (tron[j], tron[i]);
                    }
                    txtKQ.Text = string.Join(" ", tron);
                }
                catch
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ!");
                    return;
                }
            }
        }
      
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (arr == null)
                return;
            double tong = arr.Sum();
            txtKQ.Text = "Tổng mảng = "+tong.ToString();
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            if (arr == null)
                return;
            int dem = arr.Count(x => x % 2 != 0);
            txtKQ.Text = "Số phần tử lẻ = " + dem.ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (arr == null)
                return;
            double tongle = arr.Where(x => x % 2 != 0).Sum();
            txtKQ.Text = "Tổng phần tử lẻ = " + tongle.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (arr == null)
                return;
            int min = arr.Min();
            txtKQ.Text = "Phần tử nhỏ nhất = " + min.ToString();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (arr == null)
                return;
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 2;
            txtKQ.Text = string.Join(" ", arr);
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            txtKQ.Text = string.Join(" ", arr);
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            Array.Reverse(arr);
            txtKQ.Text = string.Join(" ", arr);
        }
    }
}
