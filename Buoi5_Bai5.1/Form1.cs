using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool KiemTraSTN(int n)
        {
            if (n < 2)
                return false;
            for(int i=2;i<= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int n))
            {
                if (KiemTraSTN(n))
                    lblKetqua.Text = $"{n} là số nguyên tố";
                else
                    lblKetqua.Text = $"{n}  không phải là số nguyên tố";
                var list = Enumerable.Range(2, n - 2).Where(KiemTraSTN).ToList();
                lblNho.Text = string.Join(" ", list);
            }
            else
            {
                lblKetqua.Text = "";
                lblNho.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            lblKetqua.Text = "";
            lblNho.Text = "";
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
