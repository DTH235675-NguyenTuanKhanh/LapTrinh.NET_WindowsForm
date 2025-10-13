using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if(this.txtHoten.Text =="")
            {
                MessageBox.Show("Nhập họ tên", "Thông báo"); this.txtHoten.Focus();
            }
            else
            {
                string hoten=this.txtHoten.Text;
                if (this.rdoChuthuong.Checked==true)
                    this.txtKq.Text=hoten.ToLower();                
                if (this.rdoChuHoa.Checked==true)
                        this.txtKq.Text=hoten.ToUpper();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoten.Clear();
            this.txtKq.Clear();
            this.txtHoten.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
