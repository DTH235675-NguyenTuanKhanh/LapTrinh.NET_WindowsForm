using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            if (b != 0)
                txtKq.Text = (a / b).ToString();
            else
                MessageBox.Show("Mẫu số phải khác 0", "Lỗi");
        }

        private void tsmCong_Click(object sender, EventArgs e)
        {
            int a= int.Parse(txta.Text);
            int b= int.Parse(txtb.Text);
            int kq = a + b;
            txtKq.Text = kq.ToString();
        }

        private void tsmTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);   
            int kq = a - b;
            txtKq.Text = kq.ToString();
        }

        private void tsmNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double kq = a * b;
            txtKq.Text = kq.ToString();
        }
    }
}
