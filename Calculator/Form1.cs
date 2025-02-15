using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
          
            if (double.TryParse(txt_a.Text, out double a) && double.TryParse(txt_b.Text, out double b))
            {
                double kq = a + b; 
                txt_kq.Text = kq.ToString(); 
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
