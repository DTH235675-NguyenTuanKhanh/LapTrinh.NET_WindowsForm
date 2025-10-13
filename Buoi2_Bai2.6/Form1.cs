using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so nguyen cho a");
                return;
            }
            if (!int.TryParse(txtb.Text.Trim(), out b))
            {
                MessageBox.Show("Vui long nhap so nguyen cho b");
            }
            double Tich = a * b;
            MessageBox.Show("Tich: " + Tich.ToString(), "Ket Qua");
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so nguyen cho a");
                return;
            }
            if (!int.TryParse(txtb.Text.Trim(), out b))
            {
                MessageBox.Show("Vui long nhap so nguyen cho b");
            }
            int Tong = a + b;
            MessageBox.Show("Tong: " + Tong.ToString(), "Ket Qua");
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so nguyen cho a");
                return;
            }
            if (!int.TryParse(txtb.Text.Trim(), out b))
            {
                MessageBox.Show("Vui long nhap so nguyen cho b");
            }
            double hieu = a - b;
            MessageBox.Show("Hieu: " + hieu.ToString(), "Ket Qua");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so nguyen cho a");
                return;
            }
            if (!int.TryParse(txtb.Text.Trim(), out b))
            {
                MessageBox.Show("Vui long nhap so nguyen cho b");
            }
            double Thuong = a / b;
            MessageBox.Show("Thuong: " + Thuong.ToString(), "Ket Qua");
        }
    }
}
