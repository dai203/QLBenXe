using BUS;
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
    public partial class Form_Nguoi_Dung_Mua_Ve : Form
    {
        private string maND { get; set; }
        private string maVE { get; set; }
        public Form_Nguoi_Dung_Mua_Ve()
        {
            InitializeComponent();
        }
        public Form_Nguoi_Dung_Mua_Ve(string maND)
        {
            InitializeComponent();
            this.maND = maND;
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
        private void Form_Nguoi_Dung_Mua_Ve_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void txtTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMuaVe_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
                if (nguoiDung.NguoiDungMuaVe(maVE, maND))
                {
                    MessageBox.Show("Mua Vé Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Mua Vé Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Vé Đã Được Mua, Vui Lòng Xem Chi Tiết Ở Trong Giỏ Hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0) return;
            ListViewItem item = lsvHienThi.SelectedItems[0];
            maVE = item.SubItems[0].Text;
      
        }
    }
}
