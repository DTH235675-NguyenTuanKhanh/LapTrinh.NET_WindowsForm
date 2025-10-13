using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int TimMax(int so1,int so2)
        {
            if (so1 < so2)
                return so2;
            else
                return so1;
        }
        public string UC(int a,int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for(int i=1;i<=max;i++)
                if ((a % i == 0) && (b % i == 0))
                    chuoi += " "+ i.ToString();
                return chuoi;
            
        }
        public int UCLN(int a,int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtn.Text);
            b = int.Parse(this.txtm.Text);
            if (this.rdo1.Checked == true)
                this.txtKq.Text = UC(a, b);
            if (this.rdo2.Checked == true)
                this.txtKq.Text = UCLN(a, b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtKq.Clear();
            this.txtm.Clear();
            this.txtn.Clear();
            this.txtKq.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
