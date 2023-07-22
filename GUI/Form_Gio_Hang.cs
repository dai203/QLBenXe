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
    public partial class Form_Gio_Hang : Form
    {
        private string maND { get; set; }
        private string maVe { get; set; }
        public Form_Gio_Hang()
        {
            InitializeComponent();
        }
        public Form_Gio_Hang(string maND) 
        {
            InitializeComponent();
            this.maND = maND;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hienThi()
        {
            BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
            SqlDataReader reader = nguoiDung.HienThiVeDaMua(maND);
            lsvHienThi.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetDouble(3).ToString());
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                item.SubItems.Add(reader.GetString(7));
                item.SubItems.Add(reader.GetString(8));
                item.SubItems.Add(reader.GetString(9));
                item.SubItems.Add(reader.GetString(10));
                lsvHienThi.Items.Add(item);
            }
            reader.Close();
        }
        private void Form_Gio_Hang_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0) return;
            ListViewItem item = lsvHienThi.SelectedItems[0];
            maVe = item.SubItems[0].Text;
        }

        private void btnHuyMua_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
                if (nguoiDung.loaiBoVeDaMua(maVe, maND))
                {
                    MessageBox.Show("Bỏ Mua Vé Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();
                }else
                {
                    MessageBox.Show("Bỏ Mua Vé Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Bỏ Mua Vé Không Thành Công. Đã Xảy Ra Lỗi Trong CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
