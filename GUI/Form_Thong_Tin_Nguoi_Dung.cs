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
    public partial class Form_Thong_Tin_Nguoi_Dung : Form
    {
        private string maTK { get; set; }
        private string maND { get; set; }
        public Form_Thong_Tin_Nguoi_Dung()
        {
            InitializeComponent();
        }
        public Form_Thong_Tin_Nguoi_Dung(string maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
        }
        public void HienThi()
        {
            BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
            SqlDataReader reader = nguoiDung.layThongTinTK(maTK);
            while(reader.Read())
            {
                txtHoTen.Text = reader.GetString(0);
                txtDiaChi.Text = reader.GetString(1);
                txtSDT.Text = reader.GetString(2);
                maND = reader.GetString(3);
            }
            reader.Close();
        }
        private void Form_Thong_Tin_Nguoi_Dung_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_NguoiDung nguoiDung = new BUS_NguoiDung();
                if (nguoiDung.NguoiDungCapNhatThongTin(txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, maND))
                {
                    MessageBox.Show("Cập Nhật Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                }else
                {
                    MessageBox.Show("Cập Nhật Thông Tin Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập Nhật Thông Tin Không Thành Công, Đã Xảy Ra Lỗi Ở CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
