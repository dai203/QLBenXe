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
    public partial class Form_Quan_Ly_Ve : Form
    {
        private string loaiVe { get; set; }
        private string maXe { get; set; }
        private string maVE { get; set; }
        public Form_Quan_Ly_Ve()
        {
            InitializeComponent();
        }
        public void hienThi()
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();
            SqlDataReader reader = quanLy.bus_HienThiVe();
            lsvHienThi.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetDouble(3).ToString());
                item.SubItems.Add((reader.GetString(4)));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }
        private void Form_Quan_Ly_Ve_Load(object sender, EventArgs e)
        {
            hienThi();
            MaXe();
            LoaiVe();
        }

        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0) return;
            ListViewItem item = lsvHienThi.SelectedItems[0];
            maVE = item.SubItems[0].Text;
            txtTenVe.Text = item.SubItems[1].Text;
            txtGiaVe.Text = item.SubItems[3].Text;
        }
       
        public void LoaiVe()
        {
            comboLoaiVe.Items.Add("Vé Ngày");
            comboLoaiVe.Items.Add("Vé Tháng");
            comboLoaiVe.Items.Add("Vé 6 Tháng");
            comboLoaiVe.Items.Add("Vé Năm");
            comboLoaiVe.Items.Add("Vé Sinh Viên");
            comboLoaiVe.Items.Add("Vé Người Có Công");
            comboLoaiVe.SelectedIndex = 1;

        }
        public void MaXe()
        {
            Bus_QuanLy quanLy = new Bus_QuanLy();

            SqlDataReader reader = quanLy.bus_TraVeMaVe();
            int cnt = 0;
            while (reader.Read())
            {
                comboMaXe.Items.Add(reader.GetString(0));
                ++cnt;
            }
            if (cnt > 0)
            {
                comboMaXe.SelectedIndex = 0;
            }
        }
        private void comboLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaiVe = comboLoaiVe.SelectedItem.ToString();
        }

        private void comboMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            maXe = comboMaXe.SelectedItem.ToString();
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            if (txtTenVe.Text != "" && txtGiaVe.Text != "")
            {
                Bus_QuanLy quanLy = new Bus_QuanLy();
                VE ve = new VE("", txtTenVe.Text, loaiVe, txtGiaVe.Text, maXe);
                try
                {
                    if (quanLy.bus_QuanLyThemVe(ve))
                    {
                        MessageBox.Show("Thêm Vé Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThi();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch
                {
                    MessageBox.Show("Đã Xảy Ra Lỗi Trong Cơ Sở Dữ Liệu. Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                    MessageBox.Show("Các Thông Tin Không Được Rỗng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaVe_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            VE ve = new VE(maVE, txtTenVe.Text, loaiVe, txtGiaVe.Text, maXe);
            try
            {
                if (quanLy.suaVe(ve))
                {
                    MessageBox.Show("Sửa Vé Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Cơ Sở Dữ Liệu. Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaVe_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLy quanLy = new QuanLy();   
                if (quanLy.xoaVe(maXe))
                {
                    MessageBox.Show("Xóa Vé Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Cơ Sở Dữ Liệu. Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiemKiemVe_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            SqlDataReader reader = quanLy.timKiemVe(txtTimKiem.Text);
            lsvHienThi.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetDouble(3).ToString());
                item.SubItems.Add((reader.GetString(4)));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
