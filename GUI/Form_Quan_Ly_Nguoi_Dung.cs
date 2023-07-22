using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Quan_Ly_Nguoi_Dung : Form
    {
        private Bus_QuanLy quanLy = new Bus_QuanLy();
        private string maTK { get; set; }
        private string maND { get; set; }
        private string tenND { get; set; }
        public Form_Quan_Ly_Nguoi_Dung()
        {
            InitializeComponent();
        }

        private void Form_Quan_Ly_Nguoi_Dung_Load(object sender, EventArgs e)
        {
            HienThi();
            MaTK();
        }
        private void HienThi()
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();
            SqlDataReader reader = quanLy.hienThiNguoiDung();
            lsvHienThi.Items.Clear();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetDouble(5).ToString());
                item.SubItems.Add(reader.GetString(4));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }
        private void MaTK()
        {
            List<string> list = new List<string>();
            list = quanLy.getMaTK();
            int cnt = 0;
            foreach (string s in list)
            {
                ++cnt;
                comboMaTaiKhoan.Items.Add(s);
            }
            if (cnt > 0)
            {
                comboMaTaiKhoan.SelectedIndex = 0;
            }
          
        }
        private void comboMaTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            maTK = comboMaTaiKhoan.SelectedItem.ToString();
        }

        private void btnTiemKiemNguoiDung_Click(object sender, EventArgs e)
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();
            SqlDataReader reader = quanLy.bus_QLTimKiemNguoiDung(txtTimKiem.Text);
            lsvHienThi.Items.Clear();
            if (reader.HasRows)
            {
                MessageBox.Show("Tìm Kiếm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetString(2));
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetDouble(5).ToString());
                    item.SubItems.Add(reader.GetString(4));
                    lsvHienThi.Items.Add(item);
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Tìm Kiếm Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text != "" && txtSoTien.Text != "" && txtSoDienThoai.Text != "" && txtDiaChi.Text != "")
            {
                try
                {
                    Bus_QuanLy quanLy = new Bus_QuanLy();
                    NguoiDung nguoiDung = new NguoiDung("", txtTenNguoiDung.Text, txtDiaChi.Text, txtSoDienThoai.Text, maTK, float.Parse(txtSoTien.Text));
                    if (quanLy.bus_QLthemNguoiDung(nguoiDung))
                    {
                        MessageBox.Show("Thêm Người Dùng Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }else
                    {
                        MessageBox.Show("Thêm Người Dùng Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Thêm Người Dùng Không Thành Công. Đã Xảy Ra Lỗi Trong CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin Để Tiếp Tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text != "" && txtSoTien.Text != "" && txtSoDienThoai.Text != "" && txtDiaChi.Text != "")
            {
                try
                {
                    Bus_QuanLy quanLy = new Bus_QuanLy();
                    NguoiDung nguoiDung = new NguoiDung(maND, txtTenNguoiDung.Text, txtDiaChi.Text, txtSoDienThoai.Text, maTK, float.Parse(txtSoTien.Text));
                    if (quanLy.bus_QLSuaNguoiDung(nguoiDung))
                    {
                        MessageBox.Show("Sửa Thông Tin Người Dùng Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thông Tin Người Dùng Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Sửa Thông Tin Người Dùng Không Thành Công. Đã Xảy Ra Lỗi Trong CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin Để Tiếp Tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0) return;
            ListViewItem item = lsvHienThi.SelectedItems[0];
            maND = item.SubItems[0].Text;
            tenND = item.SubItems[1].Text;
            txtTenNguoiDung.Text = item.SubItems[1].Text;
            txtDiaChi.Text = item.SubItems[2].Text;
            txtSoDienThoai.Text = item.SubItems[3].Text;
            txtSoTien.Text = item.SubItems[4].Text;
        }

        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                Bus_QuanLy quanLy = new Bus_QuanLy();
                if (quanLy.bus_QLXoaNguoiDung(maND) || quanLy.bus_QLXoaNguoiDungDaMuaVe(maND))
                {
                    MessageBox.Show("Xóa Thông Tin Người Dùng Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Xóa Thông Tin Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Xóa Thông Tin Không Thành Công. Đã Xảy Ra Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
