using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class Bus_QuanLy
    {
        private QuanLy quanLy = new QuanLy();
        // Quản Lý Thêm Tài Khoản
        public bool bus_QuanLy_ThemTaiKhoan(TaiKhoan taiKhoan)
        {
             return quanLy.themTaiKhoan(taiKhoan);
        }
        // Quản Lý Sửa Tài Khoản
        public bool bus_QuanLy_SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            return quanLy.suaTaiKhoan(taiKhoan);
        }
        // Quản Lý Xóa Tài Khoản
        public bool bus_QuanLy_XoaTaiKhoan(string maTK)
        {
            return quanLy.xoaTaiKhoan(maTK);
        }
        // Quản lý tìm kiếm tài khoản
        public SqlDataReader bus_QuanLy_TimKiemTaiKhoan(string tenTK)
        {
            return quanLy.timKiemTaiKhoan(tenTK);
        }
        // Hiển thị thông tin tài khoản
        public SqlDataReader bus_HienThiThongTinTaiKhoan()
        {
            return QuanLy.hienThiThongTin();
        }
        // Quản Lý Xóa Người Dùng
        public bool bus_QuanLyXoaNguoiDung(string maTK)
        {
            return quanLy.xoaNguoiDung(maTK);
        }
        // Quản Lý Thêm Xe
        public bool bus_QuanLyThemXe(XE xe)
        {
            return quanLy.themXe(xe);
        }
        // Quản Lý Sửa Xe
        public bool bus_QuanLySuaXe(XE xe)
        {
            return quanLy.suaXe(xe);
        }
        // Quản Lý Xóa Xe
        public bool bus_QuanLyXoaXe(string maXe)
        {
            return quanLy.xoaXe(maXe);
        }
        // Quản Lý Xóa Vé
        public bool bus_QuanLyXoaVe(string maXe)
        {
            return quanLy.xoaVe(maXe);
        }
        // Quản Lý Tìm Kiếm Xe
        public SqlDataReader bus_TimKiemXe(string tenXe)
        {
            return quanLy.timKiemXe(tenXe);
        }
        // Quản Lý Hiển Thị Xe
        public SqlDataReader bus_HienThiXe()
        {
            return QuanLy.hienThiXe();
        }
        // Quản lý thêm vé
        public bool bus_QuanLyThemVe(VE ve)
        {
            return quanLy.themVe(ve);
        }
        // Quản lý sửa vé
        public bool bus_QuanLySuaVe(VE ve)
        {
            return quanLy.suaVe(ve);
        }
        // Quản lý tìm kiếm vé
        public SqlDataReader bus_QuanLyTimKiemVe(string tenVe)
        {
            return quanLy.timKiemVe(tenVe);
        }
        // Quản lý hiển thị vé
        public SqlDataReader bus_HienThiVe()
        {
            return QuanLy.hienThiVe();
        }
        // Quản lý xóa bỏ vé khi có người mua
        public bool bus_XoaVeKhiCoNguoiMua(string maVE)
        {
            return quanLy.xoaVeKhiNguoiDungDaMua(maVE);
        }
        // Trả về mã vé
        public SqlDataReader bus_TraVeMaVe()
        {
            return quanLy.TraVeMaVe();
        }
        // Chức năng quản lý người dùng
        // Thêm Người Dùng
        public bool bus_QLthemNguoiDung(NguoiDung nguoiDung)
        {
            return quanLy.themNguoiDung(nguoiDung);
        }
        // Sửa Người Dùng
        public bool bus_QLSuaNguoiDung(NguoiDung nguoiDung)
        {
            return quanLy.suaNguoiDung(nguoiDung);
        }
        // Xóa Người Dùng QL
        public bool bus_QLXoaNguoiDung(string maND)
        {
            return quanLy.Bus_xoaNguoiDung(maND);
        }
        // Xóa Người Dùng Đã Mua Vé 
        public bool bus_QLXoaNguoiDungDaMuaVe(string maND )
        {
            return quanLy.Bus_xoaNguoiDung_MuaVe(maND);
        }
        // Tìm Kiếm Người Dùng
        public SqlDataReader bus_QLTimKiemNguoiDung(string tenND)
        {
            return quanLy.timKiemNguoiDung(tenND);
        }
        // Hiển Thị Người Dùng
        public SqlDataReader hienThiNguoiDung()
        {
            return QuanLy.hienThiNguoiDung();
        }
        // Lấy Mã Tài Khoản
        public List<string> getMaTK()
        {
            quanLy.getMaTK();
            return quanLy.maTK;
        }
        // Quản lý tạo báo cáo
        public  DataTable taoBaoCao()
        {
            return quanLy.baoCao();
        }
    }
}
