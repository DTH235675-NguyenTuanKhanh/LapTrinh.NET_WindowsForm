using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstWeb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Tuổi trẻ");
            this.lstWeb.Items.Add("Thanh niên");
            this.lstWeb.Items.Add("VNExpress");
            this.lstWeb.Items.Add("Dân trí");
            this.lstWeb.Items.Add("Công an");
            this.lstWeb.SelectedItem = "Tuổi trẻ";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "Bạn đã chọn website ";
            this.txtKq.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKq.Clear();
        }
    }
}
