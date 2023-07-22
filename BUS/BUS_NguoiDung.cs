using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NguoiDung
    {
        NguoiDung nguoiDung = new NguoiDung();
        // Đăng Ký Tài Khoản
        public bool dangKyTaiKhoan(TaiKhoan taiKhoan)
        {
            return nguoiDung.dangKy(taiKhoan);
        }
        // Lấy Mã Tài Khoản
        public string getMaTK(string tenTK, string matKhau)
        {
            return nguoiDung.traVeMaTK(tenTK, matKhau);
        }
        // Kiểm Tra Có Trùng Tài Khoản Trong CSDL Không
        public bool checkTK (string tenTK)
        {
            return nguoiDung.checkTK(tenTK);
        }
        // Đăng Ký Thông Tin Người Dùng
        public bool dangKyThongTinNguoiDung(NguoiDung nguoiDung)
        {
            return nguoiDung.dangKyThongTin(nguoiDung);
        }
        // Quên mật khẩu
        public string quenMatKhau(string tenTK)
        {
            return nguoiDung.quenMatKhau(tenTK);
        }
        // Người dùng đăng nhập
        public bool dangNhap(string tenTK, string matKhau)
        {
            return nguoiDung.dangNhap(tenTK, matKhau);
        }
        // Lấy mã tk người dùng
        public string layMaTKNguoiDung(string ten, string mk)
        {
            return nguoiDung.layMaTK(ten, mk);
        }
        // Lấy Thông Tin Từ Mã TK
        public SqlDataReader layThongTinTK(string maTK)
        {
            return nguoiDung.layThongTin(maTK);
        }
        // Người Dùng Cập Nhật Thông Tin
        public bool NguoiDungCapNhatThongTin(string tenND, string diaChi, string sdt, string maND)
        {
            return nguoiDung.CapNhatThongTin(tenND, diaChi, sdt, maND);
        }
        // Lấy mã Người Dùng Từ MÃ TK
        public string layMaNguoiDung (string maTK)
        {
            return nguoiDung.maNguoiDungTuMaTK(maTK);
        }
        // Người Dùng Mua Vé
        public bool NguoiDungMuaVe(string maVe, string maND)
        {
            return nguoiDung.NguoiDungMuaVe(maVe, maND);
        }
        // Hiển Thị Vé Mà Người Dùng Mua
        public SqlDataReader HienThiVeDaMua(string maND)
        {
            return nguoiDung.HienThiVeNguoiDungDaMua(maND);
        }
        // Loại bỏ vé đã mua
        public bool loaiBoVeDaMua(string maVe, string maND)
        {
            return nguoiDung.boMuaVe(maND, maVe);
        }
    }
}
