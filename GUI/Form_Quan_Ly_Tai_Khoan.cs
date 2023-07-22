using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Quan_Ly_Tai_Khoan : Form
    {
        public Form_Quan_Ly_Tai_Khoan()
        {
            InitializeComponent();
        }
        public void HienThiThongTin()
        {
            Bus_QuanLy quanly = new Bus_QuanLy();
            SqlDataReader reader = quanly.bus_HienThiThongTinTaiKhoan();
            lsvHienThi.Items.Clear();
            while(reader.Read()) { 
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }
        private void Form_Quan_Ly_Tai_Khoan_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
        string maTK = "";

        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0) return;
            ListViewItem item = lsvHienThi.SelectedItems[0];
            maTK = item.SubItems[0].Text;
            txtTenTaiKhoan.Text = item.SubItems[1].Text;
            txtMatKhau.Text = item.SubItems[2].Text;
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                try
                {
                    Bus_QuanLy quanly = new Bus_QuanLy();
                    TaiKhoan taiKhoan = new TaiKhoan("", txtTenTaiKhoan.Text, txtMatKhau.Text);
                    if (quanly.bus_QuanLy_ThemTaiKhoan(taiKhoan))
                    {
                         MessageBox.Show("Thêm Tài Khoản Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTin();
                    }
                }
                catch
                {
                   MessageBox.Show("Thêm Tài Không Thành Công. Đã xảy ra lỗi trong CSDL, thử lại sau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Thông Tin Không Được Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            Bus_QuanLy quanly = new Bus_QuanLy();
            TaiKhoan taiKhoan = new TaiKhoan(maTK,txtTenTaiKhoan.Text, txtMatKhau.Text);
            if (quanly.bus_QuanLy_SuaTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Sửa Tài Khoản Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiThongTin();
            }else
            {
                MessageBox.Show("Sửa Tài Khoản Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                Bus_QuanLy quanLy = new Bus_QuanLy();
                BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
                string maND = nguoiDung.layMaNguoiDung(maTK);
                if ((quanLy.bus_QLXoaNguoiDung(maND) && quanLy.bus_QuanLy_XoaTaiKhoan(maTK)) || quanLy.bus_QuanLy_XoaTaiKhoan(maTK))
                {
                    MessageBox.Show("Xóa Thông Tin Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiThongTin();
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Cơ Sở Dữ Liệu. Vui Lòng Thao Tác Lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiemKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();
            SqlDataReader reader =  quanLy.bus_QuanLy_TimKiemTaiKhoan(txtTimKiem.Text);
            if (reader != null) 
            {
                lsvHienThi.Items.Clear();
                MessageBox.Show("Tìm Kiếm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetString(2));
                    lsvHienThi.Items.Add(item);
                }
                reader.Close();
            }else
            {
                lsvHienThi.Items.Clear ();
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
