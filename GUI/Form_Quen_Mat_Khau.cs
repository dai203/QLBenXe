using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Quen_Mat_Khau : Form
    {
        public Form_Quen_Mat_Khau()
        {
            InitializeComponent();
        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
            if (nguoiDung.quenMatKhau(txtTenTaiKhoan.Text) != "null")
            {
                txtLayLaiMatKhau.Text = nguoiDung.quenMatKhau(txtTenTaiKhoan.Text);
            }else
            {
                MessageBox.Show("Tài Khoản Bạn Cung Cấp Không Trùng Với Bất Kỳ Tài Khoản Nào Trong Hệ Thống.", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Quen_Mat_Khau_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
