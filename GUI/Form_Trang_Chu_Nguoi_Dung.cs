using BUS;
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
    public partial class Form_Trang_Chu_Nguoi_Dung : Form
    {
        private string maTK { get; set; }
        public Form_Trang_Chu_Nguoi_Dung()
        {
            InitializeComponent();
        }
        public Form_Trang_Chu_Nguoi_Dung(string maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
            string maND = nguoiDung.layMaNguoiDung(maTK);
            Form_Nguoi_Dung_Mua_Ve form_Nguoi_Dung_Mua_Ve = new Form_Nguoi_Dung_Mua_Ve(maND);
            form_Nguoi_Dung_Mua_Ve.ShowDialog();
        }

        private void Form_Trang_Chu_Nguoi_Dung_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXemThongTinXe_Click(object sender, EventArgs e)
        {
            Form_Nguoi_Dung_Xem_Thong_Tin_Xe xem_Thong_Tin_Xe = new Form_Nguoi_Dung_Xem_Thong_Tin_Xe(maTK);
            xem_Thong_Tin_Xe.ShowDialog();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form_Thong_Tin_Nguoi_Dung thong_Tin_Nguoi_Dung = new Form_Thong_Tin_Nguoi_Dung(maTK);
            thong_Tin_Nguoi_Dung.ShowDialog();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
            string maND = nguoiDung.layMaNguoiDung(maTK);
            Form_Gio_Hang form_Gio_Hang = new Form_Gio_Hang(maND);
            form_Gio_Hang.ShowDialog();
        }
    }
}
