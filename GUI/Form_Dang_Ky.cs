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
    public partial class Form_Dang_Ky : Form
    {
        public Form_Dang_Ky()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
             BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
             if (txtTenTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtNhapLaiMatKhau.Text != "" && txtMatKhau.Text == txtNhapLaiMatKhau.Text)
                {
                if (nguoiDung.checkTK(txtTenTaiKhoan.Text))
                {
                    TaiKhoan taiKhoan = new TaiKhoan("", txtTenTaiKhoan.Text, txtMatKhau.Text);
                    try
                    {
                        if (nguoiDung.dangKyTaiKhoan(taiKhoan))
                        {
                            string s = nguoiDung.getMaTK(txtTenTaiKhoan.Text, txtMatKhau.Text);
                            MessageBox.Show("Đăng Ký Tài Khoản Thành Công. Vui Lòng Đăng Ký Thông Tin Của Bạn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Dang_Ky_Thong_Tin_Nguoi_Dung form_Dang_Ky_Thong_Tin_Nguoi_Dung = new Form_Dang_Ky_Thong_Tin_Nguoi_Dung(s);
                            form_Dang_Ky_Thong_Tin_Nguoi_Dung.ShowDialog();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đăng Ký Tài Khoản Không Thành Công. Tài Khoản Đã Tồn Tại Trong CSDL.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Tên Tài Khoản Đã Tồn Tại, Vui Lòng Chọn Một Tên Khác","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Các Thông Tin Không Được Rỗng, Mật Khẩu Và Mật Khẩu Nhập Lại Phải Trùng Nhau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Dang_Ky_Load(object sender, EventArgs e)
        {

        }
    }
}
