using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._7
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string s = txtNhap.Text.Trim();
            arr = s.Where(char.IsDigit).Select(c => int.Parse(c.ToString())).ToArray();
            txtKQ.Text = string.Join(" ", arr);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            int tong = arr.Sum();
            int tongchan = arr.Where(x => x % 2 == 0).Sum();
            int tongle = arr.Where(x => x % 2 != 0).Sum();

            txtTong.Text = tong.ToString();
            txtTC.Text = tongchan.ToString();
            txtTL.Text = tongle.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            int max = arr.Max();
            int min = arr.Min();

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            if (rdoTang.Checked)
                arr = arr.OrderBy(x => x).ToArray();
            else if (rdoGiam.Checked)
                arr = arr.OrderByDescending(x => x).ToArray();

            txtKQ.Text = string.Join(" ", arr);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            int vt = int.Parse(txtVT.Text);
            int so = int.Parse(txtSTT.Text);

            if (vt >= 0 && vt < arr.Length)
            {
                arr[vt] = so;
                txtKQ.Text = string.Join(" ", arr);
            }
            else
            {
                MessageBox.Show("Vị trí không hợp lệ!");
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKQ.Clear();
            txtTong.Clear();
            txtTC.Clear();
            txtTL.Clear();
            txtVT.Clear();
            txtSTT.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
