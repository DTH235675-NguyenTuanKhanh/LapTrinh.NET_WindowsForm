using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblKq_Click(object sender, EventArgs e)
        {

        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            if(rdoVuong.Checked)
            {
                double canh = double.Parse(txtCanh.Text);
                txtcv.Text = (4 * canh).ToString();
                txtdt.Text = (canh*canh).ToString();
            }
            if(rdoTamgiac.Checked)
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                double c = double.Parse(txtc.Text);
                txtcvtamgiac.Text = (a+b+c).ToString();
                double p = (a + b + c) / 2;
                txtdttamgiac.Text = Math.Sqrt(p*(p-a)*(p-b)*(p-c)).ToString();
            }
            if (rdoTron.Checked)
            {
                double r = double.Parse(txttron.Text);
                txtcvtron.Text = (2 * Math.PI * r).ToString();
                txtdttron.Text = (r * r).ToString();
            }
            if (rdoCn.Checked)
            {
                double dai = double.Parse(txtdai.Text);
                double rong = double.Parse(txtrong.Text);
                txtcvchunhat.Text = ((dai+rong)*2).ToString();
                txtdtchunhat.Text = (dai*rong).ToString();
            }
        }

        private void rdoTron_CheckedChanged(object sender, EventArgs e)
        {
            grpHv.Visible = false;
            grptamgiac.Visible = false;
            grpTron.Visible = rdoTron.Checked;
            grpChuNhat.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCanh.Text = "";
            txtCanh.Focus();
            txtcv.Clear();
            txtdt.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grpChuNhat_Enter(object sender, EventArgs e)
        {

        }

        private void grptamgiac_Enter(object sender, EventArgs e)
        {

        }

        private void grpTron_Enter(object sender, EventArgs e)
        {

        }

        private void grpHv_Enter(object sender, EventArgs e)
        {

        }

        private void txttron_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoVuong_CheckedChanged(object sender, EventArgs e)
        {
            grpHv.Visible = rdoVuong.Checked;
            grptamgiac.Visible = false;
            grpTron.Visible = false;
            grpChuNhat.Visible = false;
        }

        private void rdoTamgiac_CheckedChanged(object sender, EventArgs e)
        {
            grpHv.Visible = false;
            grptamgiac.Visible = rdoTamgiac.Checked;
            grpTron.Visible = false;
            grpChuNhat.Visible = false;
        }

        private void rdoCn_CheckedChanged(object sender, EventArgs e)
        {
            grpHv.Visible = false;
            grptamgiac.Visible = false;
            grpTron.Visible = false;
            grpChuNhat.Visible = rdoCn.Checked;
        }
    }
}
