using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
