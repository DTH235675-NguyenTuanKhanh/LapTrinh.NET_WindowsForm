using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int UCLN(int a,int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(b!=0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        private void RutGon(ref int tu, ref int mau)
        {
            int ucln = UCLN(tu, mau);
            tu /= ucln;
            mau /= ucln;
            if(mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau2 = int.Parse(txtMau2.Text);

            int tu = tu1 * mau2 + tu2 * mau1;
            int mau = mau1 * mau2;
            RutGon(ref tu, ref mau);
            txtTuKq.Text =tu.ToString();
            txtMauKq.Text = mau.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau2 = int.Parse(txtMau2.Text);

            int tu = tu1 * mau2 - tu2 * mau1;
            int mau = mau1 * mau2;
            RutGon(ref tu, ref mau);
            txtTuKq.Text = tu.ToString();
            txtMauKq.Text = mau.ToString();

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau2 = int.Parse(txtMau2.Text);

            int tu = tu1 * tu2;
            int mau = mau1 * mau2;
            RutGon(ref tu, ref mau);
            txtTuKq.Text = tu.ToString();
            txtMauKq.Text = mau.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau2 = int.Parse(txtMau2.Text);

            int tu = tu1 * mau2;
            int mau = mau1 * tu2;
            RutGon(ref tu, ref mau);
            txtTuKq.Text = tu.ToString();
            txtMauKq.Text = mau.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            txtMau1.Clear();
            txtMau2.Clear();
            txtTu1.Clear();
            txtTu2.Clear();
            txtMauKq.Clear();   
            txtTuKq.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
