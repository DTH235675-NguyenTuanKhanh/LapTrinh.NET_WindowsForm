using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] a = new int[10];
        int sopt = 0;
        //phuong thuc in mang
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        //phuong thuc tim max
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        //phuong thuc tinh trung binh
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        public double TongMang()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            return sum;
        }
        //phuong thuc sap xep tang
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }
        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt);
            Array.Reverse(a, 0, sopt);
        }
        //phuong thuc tim UCLN cua 2 so
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        //phuong thuc kiem tra so hoan hao
        public Boolean kiemTraSHH(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }
        //phuong thuc dem SHH
        public int demSHH()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]))
                    dem++;
            }
            return dem;
        }
        //phuong thuc in SHH
        public String inSHH()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public Boolean kiemTraSNT(int so)
        {
            if (so < 2) return false;   // 0,1 và số âm không phải số nguyên tố
            if (so == 2) return true;   // 2 là số nguyên tố
            if (so % 2 == 0) return false; // chẵn > 2 không phải số nguyên tố

            // kiểm tra từ 3 đến căn bậc 2 của n
            int can = (int)Math.Sqrt(so);
            for (int i = 3; i <= can; i += 2)
            {
                if (so % i == 0) return false;
            }
            return true;
        }
        //phuong thuc dem SNT
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        //phuong thuc in SNT
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public Boolean ktraSoChan(int so)
        {
            for (int i = 0;i < sopt;i++)
                if (so%2==0)
                    return true;
            return false;
        }
        public int demSoChan()
        {
            int dem = 0;
            for(int i = 0;i < sopt ; i++)
                if(ktraSoChan(a[i]))
                    dem++;
            return dem;
        }
        public Boolean ktraSoLe(int so)
        {
            for (int i = 0; i < sopt; i++)
                if (so % 2 == 0)
                    return false;
            return true;
        }
        public int demSoLe()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
                if (ktraSoLe(a[i]))
                    dem++;
            return dem;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (sopt == a.Length) // nếu mảng đã đầy
            {
                txtNhap.Clear();
                MessageBox.Show("Mảng đã đầy!", "Thông báo");
            }
            else
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập phần tử mảng", "Thông báo");
                }
                else
                {
                    a[sopt] = int.Parse(txtNhap.Text); // lưu vào mảng
                    sopt++;

                    // Cập nhật hiển thị mảng trong txtMang
                    txtNhap.Text = "";
                    for (int i = 0; i < sopt; i++)
                        txtNhap.Text += a[i] + " ";

                    txtNhap.Clear();
                    txtNhap.Focus();

                    if (sopt > 0)
                        btnIn.Enabled = true; // bật nút In
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sopt = 0;
            lblKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                this.lblKQ.Text = "Đã sắp xếp mảng giảm dần" + InMang();
            }
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                this.lblKQ.Text = "Đã sắp xếp mảng tăng dần" + InMang();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TongMang();
                this.lblKQ.Text = "Tổng mảng là:";
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TimMax();
                this.lblKQ.Text = "Số lớn nhất là:";
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TimMin();
                this.lblKQ.Text = "Số nhỏ nhất là:";
            }
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TrungBinhMang();
                this.lblKQ.Text = "Trung bình mảng là:";
            }
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " +
timUCLN(a[0], a[1]).ToString();
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSHH().ToString() + " số hoàn hảo là " + inSHH();
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có" + demSoChan().ToString() + "số chẵn";
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSoLe().ToString() + " số lẻ";
        }
    }
}
