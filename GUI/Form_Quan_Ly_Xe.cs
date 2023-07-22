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
    public partial class Form_Quan_Ly_Xe : Form
    {
        public Form_Quan_Ly_Xe()
        {
            InitializeComponent();
        }
        private string SoCho { get; set; }
        private string loaiXe { get; set; }
        private string maXe { get; set; }

        private void soChoComBo()
        {
            comboSoCho.Items.Add("2 - 4 Chỗ");
            comboSoCho.Items.Add("4 - 6 Chỗ");
            comboSoCho.Items.Add("16 Chỗ");
            comboSoCho.Items.Add("32 Chỗ");
            comboSoCho.Items.Add("48 Chỗ");
            comboSoCho.SelectedIndex = 1;
        }
        private void LOAIXE()
        {
            comboLoaiXe.Items.Add("Xe Tải");
            comboLoaiXe.Items.Add("Xe Khách");
            comboLoaiXe.Items.Add("Xe Buýt");
            comboLoaiXe.Items.Add("Xe Taxi");
            comboLoaiXe.SelectedIndex = 1;
        }
        private void HienThi()
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();
            SqlDataReader reader = quanLy.bus_HienThiXe();
            lsvHienThi.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                item.SubItems.Add(reader.GetString(7));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }
        private void Quan_Ly_Xe_Load(object sender, EventArgs e)
        {
            HienThi();
            LOAIXE();
            soChoComBo();
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if ( txtThoiGianDiChuyen.Text != "" && txtTenXe.Text != "" && txtTenNguoiLai.Text != "" +
            "" && txtSoDienThoaiNguoiLai.Text != "" && txtBienSoXe.Text != "")
            {
                try
                {
                    Bus_QuanLy quanLy = new Bus_QuanLy();
                    XE xe = new XE("", SoCho, txtTenXe.Text, loaiXe, txtBienSoXe.Text, txtThoiGianDiChuyen.Text, txtTenNguoiLai.Text, txtSoDienThoaiNguoiLai.Text);
                    if (quanLy.bus_QuanLyThemXe(xe))
                    {
                        HienThi();
                        MessageBox.Show("Thêm Xe Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Thêm Xe Không Thành Công. Vui lòng kiểm tra lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm Xe Không Thành Công. Đã Xảy Ra Lỗi Trong CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                    MessageBox.Show("Vui lòng nhập đủ thông tin để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboSoCho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboSoCho.SelectedIndex == 0)
            {
                return;
            }
            SoCho = comboSoCho.SelectedItem.ToString();
        }

        private void comboLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLoaiXe.SelectedIndex == 0) { return; }
            loaiXe = comboLoaiXe.SelectedItem.ToString();
        }

        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0) { return; }
            ListViewItem item = lsvHienThi.SelectedItems[0];
            maXe = item.SubItems[0].Text;
            txtTenXe.Text = item.SubItems[1].Text;
            txtBienSoXe.Text = item.SubItems[4].Text;
            txtThoiGianDiChuyen.Text = item.SubItems[5].Text;
            txtTenNguoiLai.Text = item.SubItems[6].Text;
            txtSoDienThoaiNguoiLai.Text = item.SubItems[7].Text;
            
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            if (txtThoiGianDiChuyen.Text != "" && txtTenXe.Text != "" && txtTenNguoiLai.Text != "" +
            "" && txtSoDienThoaiNguoiLai.Text != "" && txtBienSoXe.Text != "")
            {
                try
                {
                    Bus_QuanLy quanLy = new Bus_QuanLy();
                    XE xe = new XE(maXe, SoCho, txtTenXe.Text, loaiXe, txtBienSoXe.Text, txtThoiGianDiChuyen.Text, txtTenNguoiLai.Text, txtSoDienThoaiNguoiLai.Text);
                    if (quanLy.bus_QuanLySuaXe(xe))
                    {
                        HienThi();
                        MessageBox.Show("Sửa Xe Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Xe Không Thành Công. Vui lòng kiểm tra lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa Xe Không Thành Công. Đã Xảy Ra Lỗi Trong CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
                try
                {
                    Bus_QuanLy quanLy = new Bus_QuanLy();
                    if (quanLy.bus_QuanLyXoaXe(maXe))
                    {
                        HienThi();
                        MessageBox.Show("Xóa Xe Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Xe Không Thành Công. Vui lòng kiểm tra lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa Xe Không Thành Công. Đã Xảy Ra Lỗi Trong CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnTiemKiemXe_Click(object sender, EventArgs e)
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();
            SqlDataReader reader = quanLy.bus_TimKiemXe(txtTimKiem.Text);
            lsvHienThi.Items.Clear();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                item.SubItems.Add(reader.GetString(7));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }

        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
