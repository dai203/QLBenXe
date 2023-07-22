using BUS;
using DAL;
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
    public partial class Form_Dang_Nhap : Form
    {
        public Form_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Dang_Ky dangKy = new Form_Dang_Ky();
            dangKy.ShowDialog();
        }

        private void lblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Quen_Mat_Khau form_Quen_Mat_Khau = new Form_Quen_Mat_Khau();
            form_Quen_Mat_Khau.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
            if (txtMatKhau.Text != "" && txtTenDangNhap.Text != "")
            {
                if (txtTenDangNhap.Text == "Admin" && txtMatKhau.Text == "123")
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Quan_Ly quanLy = new Form_Quan_Ly();
                    quanLy.ShowDialog();
                }else if (nguoiDung.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string maTK = nguoiDung.layMaTKNguoiDung(txtTenDangNhap.Text, txtMatKhau.Text);
                    Form_Trang_Chu_Nguoi_Dung form_Trang_Chu_Nguoi_Dung = new Form_Trang_Chu_Nguoi_Dung(maTK);
                    form_Trang_Chu_Nguoi_Dung.ShowDialog();
                }else
                {
                    MessageBox.Show("Đăng Nhập Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Và Mật Khẩu Không Được Rỗng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
