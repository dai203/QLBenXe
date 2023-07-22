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
    public partial class Form_Nguoi_Dung_Xem_Thong_Tin_Xe : Form
    {
        private string maTK { get; set; }
        public Form_Nguoi_Dung_Xem_Thong_Tin_Xe()
        {
            InitializeComponent();
        }
        public Form_Nguoi_Dung_Xem_Thong_Tin_Xe(string maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
        }
        public void hienThiXe()
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
        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Nguoi_Dung_Xem_Thong_Tin_Xe_Load(object sender, EventArgs e)
        {
            hienThiXe();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
