using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool KiemTraSHH(int n)
        {

            int sum = 0;
            for (int i = 1; i <= n/2; i++)
            
                if (n % i == 0) sum += i;
            return sum==n;
            
        }
        private void lblKq_Click(object sender, EventArgs e)
        {

        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int n))
            {
                if (KiemTraSHH(n))
                    MessageBox.Show($"{n} là số Hoàn hảo");
                else
                    MessageBox.Show($"{n}  không phải là số Hoàn hảo");
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
