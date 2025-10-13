using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int[] a)
        {
            InitializeComponent();
            c = new int[a.Length];
            a.CopyTo(c, 0);
            int max = c[0];
            foreach (int i in c) if (i > max) max = i;
            lblKQ.Text = "Phần tử lớn nhất trong mảng là: " + max;
        }
    }
}
