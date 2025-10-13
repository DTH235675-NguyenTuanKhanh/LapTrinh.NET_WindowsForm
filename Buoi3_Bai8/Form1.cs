using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbt.Items.Add("Nguyễn Tuấn Khanh");
            cbt.Items.Add("Đoàn Thị Huỳnh Giao");
            cbt.Items.Add("Nguyễn Đoàn Tuấn Khang");
        }

        private void btnht_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào " + cbt.Text + ". Chúc một ngày vui vẻ!!!", "Thông báo");
        }
    }
}
