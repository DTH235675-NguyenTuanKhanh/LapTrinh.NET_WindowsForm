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
    public partial class Form2 : Form
    {
        int[] b;
        public Form2(int[] a)
        {
            InitializeComponent();
            b=new int[a.Length];
            a.CopyTo(b,0);
            int sum = 0;
            foreach (int i in b) sum += i;
            lblKQ.Text = "Tổng các phần tử trong mảng là: " + sum;
        }
    }
}
