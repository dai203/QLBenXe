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
    public partial class Form_Quan_Ly : Form
    {
        public Form_Quan_Ly()
        {
            InitializeComponent();
        }

        private void btnXemThongTinXe_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Tai_Khoan quanLyTaiKhoan = new Form_Quan_Ly_Tai_Khoan();
            quanLyTaiKhoan.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Xe quan_Ly_Xe = new Form_Quan_Ly_Xe();
            quan_Ly_Xe.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Ve form_Quan_Ly_Ve = new Form_Quan_Ly_Ve();
            form_Quan_Ly_Ve.ShowDialog();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Nguoi_Dung form_Quan_Ly_Nguoi_Dung = new Form_Quan_Ly_Nguoi_Dung();
            form_Quan_Ly_Nguoi_Dung.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Kết Xuất Data cho report
            Bus_QuanLy quanly = new Bus_QuanLy();
            CrystalReport1 crystalReport1 = new CrystalReport1();
            crystalReport1.SetDataSource(quanly.taoBaoCao());
            // Hiển Thị Báo Cáo
            Form_Thong_Ke_Nguoi_Dung_Mua_Ve f = new Form_Thong_Ke_Nguoi_Dung_Mua_Ve();
            f.crystalReportViewer1.ReportSource  = crystalReport1;
            f.ShowDialog();
        }

        private void Form_Quan_Ly_Load(object sender, EventArgs e)
        {

        }
    }
}
