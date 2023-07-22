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
    public partial class Form_Dang_Ky_Thong_Tin_Nguoi_Dung : Form
    {
        private string maTK;
        public Form_Dang_Ky_Thong_Tin_Nguoi_Dung()
        {
            InitializeComponent();
        }
        public Form_Dang_Ky_Thong_Tin_Nguoi_Dung(string maTK)
        {
            InitializeComponent();
            this.maTK = maTK;   
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Dang_Ky_Thong_Tin_Nguoi_Dung_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtSoDienThoai.Text != "" && txtDiaChi.Text != "")
            {
                BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
                NguoiDung nguoiDung1 = new NguoiDung("", txtTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, maTK, 100f);
                try
                {
                    if (nguoiDung.dangKyThongTinNguoiDung(nguoiDung1))
                    {
                        MessageBox.Show("Đăng Ký Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Dang_Nhap dang_Nhap = new Form_Dang_Nhap();
                        dang_Nhap.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Ký Thông Tin Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Đã Xảy Ra Lỗi Trong CSDL, Thử Lại Sau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Các Thông Tin Phải Không Được Rỗng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
