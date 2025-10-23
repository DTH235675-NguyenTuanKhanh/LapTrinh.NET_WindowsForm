using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai6._3
{
    
    public partial class Form1 : Form
    {
        private List<Student> svien = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLop.Items.AddRange(new string[] { "Lớp A", "Lớp B", "Lớp C", "Lớp D", "Lớp E", "Lớp F", "Lớp G" });
            cmbLop.SelectedIndex = 0;

            dgv.Columns.Add("MaSV", "Mã SV");
            dgv.Columns.Add("HoTen", "Họ Tên");
            dgv.Columns.Add("Ngaysinh", "Ngày Sinh");
            dgv.Columns.Add("Diachi", "Địa chỉ");
            dgv.Columns.Add("Lop", "Lớp");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không để trống!", "Lỗi");
                return;
            }
            Student sv = new Student()
            {
                MaSV = string.IsNullOrWhiteSpace(txtMaSV.Text) ? "SV" + (svien.Count + 1).ToString("D3") : txtMaSV.Text.Trim(),
                Hoten = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaysinh.Value,
                Diachi = txtDiachi.Text.Trim(),
                Lop = cmbLop.Text,
            };
            svien.Add(sv);
            Hien();
            Xoa();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int index = dgv.CurrentRow.Index;
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                svien.RemoveAt(index);
                Hien();
                Xoa();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int index = dgv.CurrentRow.Index;
            if (index < 0 || index >= svien.Count) return;

            Student sv = svien[index];
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.Hoten;
            dtpNgaysinh.Value = sv.NgaySinh;
            txtDiachi.Text = sv.Diachi;
            cmbLop.Text = sv.Lop;
        }
        private void Hien()
        {
            dgv.Rows.Clear();
            foreach (var sv in svien)
            {
                dgv.Rows.Add(sv.MaSV, sv.Hoten,
                    sv.NgaySinh.ToShortDateString(), sv.Diachi, sv.Lop);
            }
        }

        private void Xoa()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiachi.Clear();
            cmbLop.SelectedIndex = 0;
            dtpNgaysinh.Value = DateTime.Today;
        }
    }
    public class Student
    {
        public string MaSV { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }

    }
}
