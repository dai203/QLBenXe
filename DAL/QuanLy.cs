using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{

    public interface IQLTaiKhoan
    {
        bool themTaiKhoan(TaiKhoan taiKhoan);
        bool suaTaiKhoan(TaiKhoan suaTaiKhoan);
        bool xoaTaiKhoan(string maTK);
        SqlDataReader timKiemTaiKhoan(string maTK);
    }
    public interface IQLXE
    {
        bool themXe(XE xe);
        bool suaXe(XE xe);
        bool xoaXe(string maXe);
        SqlDataReader timKiemXe(string tenXe);
    }
    public interface IQLVE
    {
        bool themVe(VE ve);
        bool suaVe(VE ve);
        bool xoaVe(string maVe);
        
        SqlDataReader timKiemVe(string tenVe);

    }
    public interface IQLNguoiDung
    {
        bool themNguoiDung(NguoiDung nguoiDung);
        bool suaNguoiDung(NguoiDung nguoiDung);
        bool xoaNguoiDung(string maND);
        SqlDataReader timKiemNguoiDung(string tenNguoiDung);
    }
    public class QuanLy : PERSON, IQLTaiKhoan, IQLXE, IQLVE, IQLNguoiDung    
    {
        SqlCommand sqlCMD = new SqlCommand();
        public List<string> maTK = new List<string>();
        private List<string> maXe = new List<string> { };
        private List<string> maVe = new List<string> ();
        private List<string> maND = new List<string> ();    
        private void Chung(string tenProc)
        {
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = $"{tenProc}";
        }
        private void Concect()
        {
            sqlCMD.Connection = CONECT.DBKETNET();
        }
        public QuanLy()
        {

        }
        public QuanLy(string ma, string ten, string diaChi, string sdt) : base(ma, ten, diaChi, sdt)
        {

        }
        
        // Quản Lý Sửa Tài Khoản
        public bool suaTaiKhoan(TaiKhoan suaTaiKhoan)
        {
            Chung("dboQLSuaTaiKhoan");
            sqlCMD.Parameters.Add("maTK", suaTaiKhoan.MaTK);
            sqlCMD.Parameters.Add("tenTK", suaTaiKhoan.TenTK);
            sqlCMD.Parameters.Add("matKhau", suaTaiKhoan.MatKhau);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        // Lấy Mã TK
        public void getMaTK()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaTK";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while (reader.Read())
            {
                maTK.Add(reader.GetString(0));
            }
            reader.Close();
        }
        public SqlDataReader Reader()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaTK";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Quản Lý Xóa Người Dùng
        public bool xoaNguoiDung(string ma)
        {
            Chung("dboXoaNguoiDung");
            sqlCMD.Parameters.AddWithValue("maTK", ma);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        // Quản Lý Thêm Tài Khoản
        public bool themTaiKhoan(TaiKhoan taiKhoan)
        {
            getMaTK();
        back:
            Random random = new Random();
            string x = "TK" + random.Next(1000);
            foreach (string i in maTK)
            {
                if (i == x)
                {
                    goto back;
                }
            }
            Chung("dboQLThemTaiKhoan");
            sqlCMD.Parameters.AddWithValue("maTK", x);
            sqlCMD.Parameters.AddWithValue("tenTK", taiKhoan.TenTK);
            sqlCMD.Parameters.AddWithValue("matKhau", taiKhoan.MatKhau);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;

        }
        // Quản lý tìm kiếm tài khoản
        public SqlDataReader timKiemTaiKhoan(string tenTK)
        {
            Chung("dboTimKiemTaiKhoan");
            sqlCMD.Parameters.AddWithValue("tenTK", $"%{tenTK}%");
            Concect() ;
            SqlDataReader reader = sqlCMD.ExecuteReader();
            if (reader.HasRows)
            {
                return reader;
            }else
            {
                return null;
            }
        }

        // Quản Lý Số Tài Khoản
        public bool xoaTaiKhoan(string ma)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboQLXoaTaiKhoan";
            sqlCMD.Parameters.AddWithValue("maTK", ma);
            sqlCMD.Connection = CONECT.DBKETNET();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Hiển Thị Thông Tin
        public static SqlDataReader hienThiThongTin()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboHienThiThongTin";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Lấy mã xe
        public void getMaXe()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaXe";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while (reader.Read())
            {
                maXe.Add(reader.GetString(0));
            }
            reader.Close();
        }
        // Quản lý thêm xe
        public bool themXe(XE xe)
        {
             getMaXe();
            back:
            Random random = new Random();
            string x = "XE" + random.Next(1000);
            foreach (string i in maXe)
            {
                if (i == x)
                {
                    goto back;
                }
            }
            Chung("dboThemXe");
            sqlCMD.Parameters.AddWithValue("maXe", x);
            sqlCMD.Parameters.AddWithValue("soCho", xe.SoCho);
            sqlCMD.Parameters.AddWithValue("tenXe", xe.TenXe);
            sqlCMD.Parameters.AddWithValue("loaiXe", xe.LoaiXe);
            sqlCMD.Parameters.AddWithValue("bienSo", xe.BienSo);
            sqlCMD.Parameters.AddWithValue("thoiGianDiChuyen", xe.ThoiGianDiChuyen);
            sqlCMD.Parameters.AddWithValue("tenNguoiLai", xe.TenNguoiLai);
            sqlCMD.Parameters.AddWithValue("sdtNguoiLai", xe.SdtNguoiLai);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
            
        }
        // Quản lý sửa xe
        public bool suaXe(XE xe)
        {
            Chung("dboSuaXe");
            sqlCMD.Parameters.AddWithValue("maXe", xe.MaXE);
            sqlCMD.Parameters.AddWithValue("soCho", xe.SoCho);
            sqlCMD.Parameters.AddWithValue("tenXe", xe.TenXe);
            sqlCMD.Parameters.AddWithValue("loaiXe", xe.LoaiXe);
            sqlCMD.Parameters.AddWithValue("bienSo", xe.BienSo);
            sqlCMD.Parameters.AddWithValue("thoiGianDiChuyen", xe.ThoiGianDiChuyen) ;
            sqlCMD.Parameters.AddWithValue("tenNguoiLai", xe.TenNguoiLai);
            sqlCMD.Parameters.AddWithValue("sdtNguoiLai", xe.SdtNguoiLai);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0) { return true; }
            return false;
        }
        // Quản lý xóa vé
        public bool xoaVe (string maXe)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboXoaVe";
            sqlCMD.Parameters.AddWithValue("maXe", maXe);
            sqlCMD.Connection = CONECT.DBKETNET();
            if (sqlCMD.ExecuteNonQuery() > 0) { return true; }
            return false;
        }
        // Quản lý xóa xe
        public bool xoaXe(string maXe)
        {
            Chung("dboXoaXe");
            sqlCMD.Parameters.Add("maXe", maXe);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0) { return true; }
            return false;
        }
        // Quản lý tìm kiếm xe
        public SqlDataReader timKiemXe(string tenXe)
        {
            Chung("dboTimKiemXe");
            sqlCMD.Parameters.AddWithValue("tenXe", $"%{tenXe}%");
            Concect();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Quản lý hiện thị xe
        public static SqlDataReader hienThiXe()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboHienThiXe";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Quản lý get mã vé
        public void getMaVe()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaVe";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while (reader.Read())
            {
                maVe.Add(reader.GetString(0));
            }
            reader.Close();
        }
        public SqlDataReader TraVeMaVe()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaXe";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Quản lý thêm vé
        public bool themVe(VE ve)
        {
            getMaVe();
            back:
            Random random = new Random();
            string x = "VE" + random.Next(1000);
            foreach (string i in maVe)
            {
                if (i == x)
                {
                    goto back;
                }
            }
            Chung("dboThemVe");
            sqlCMD.Parameters.AddWithValue("maVe", x);
            sqlCMD.Parameters.AddWithValue("tenVe", ve.TenXe);
            sqlCMD.Parameters.AddWithValue("loaiVe", ve.LoaiVe);
            sqlCMD.Parameters.AddWithValue("giaVe", ve.GiaVe);
            sqlCMD.Parameters.AddWithValue("maXe", ve.MaXe);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        // Quản lý sửa vé
        public bool suaVe(VE ve)
        {
            Chung("dboSuaVe");
            sqlCMD.Parameters.AddWithValue("maVe", ve.MaVe);
            sqlCMD.Parameters.AddWithValue("tenVe", ve.TenXe);
            sqlCMD.Parameters.AddWithValue("loaiVe", ve.LoaiVe);
            sqlCMD.Parameters.AddWithValue("giaVe", ve.GiaVe);
            sqlCMD.Parameters.AddWithValue("maXe", ve.MaXe);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        // Quản lý tìm kiếm vé
        public SqlDataReader timKiemVe(string tenVe)
        {
            Chung("dboTimKiemVE");
            sqlCMD.Parameters.AddWithValue("tenVe", $"%{tenVe}%");
            Concect();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Quản lý hiển thị vé
        public static SqlDataReader hienThiVe()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboHienThiVe";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Quản lý xóa vé khi người dùng mua
        public bool xoaVeKhiNguoiDungDaMua(string maVe)
        {
            Chung("dboXoaVeDaMua");
            sqlCMD.Parameters.AddWithValue("MAVE", maVe);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0) return true;
            return false;  
        }
        public void getNguoiDung()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboGetMaNguoiDung";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while (reader.Read())
            {
                maND.Add(reader.GetString(0));
            }
            reader.Close();
        }

        public bool themNguoiDung(NguoiDung nguoiDung)
        {
            getNguoiDung();
            back:
            Random random = new Random();
            string x = "ND" + random.Next(1000);
            foreach (string i in maND)
            {
                if (i == x)
                {
                    goto back;
                }
            }
            Chung("dboThemNguoiDung");
            sqlCMD.Parameters.AddWithValue("maNguoiDung", x);
            sqlCMD.Parameters.AddWithValue("tenNguoiDung", nguoiDung.ten);
            sqlCMD.Parameters.AddWithValue("DiaChi", nguoiDung.diaChi);
            sqlCMD.Parameters.AddWithValue("sdt", nguoiDung.sdt);
            sqlCMD.Parameters.AddWithValue("maTK", nguoiDung.MaTK);
            sqlCMD.Parameters.AddWithValue("Tien", nguoiDung.Tien);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        public bool suaNguoiDung(NguoiDung nguoiDung)
        {
            Chung("dboSuaNguoiDung");
            sqlCMD.Parameters.AddWithValue("maNguoiDung", nguoiDung.ma);
            sqlCMD.Parameters.AddWithValue("tenNguoiDung", nguoiDung.ten);
            sqlCMD.Parameters.AddWithValue("DiaChi", nguoiDung.diaChi);
            sqlCMD.Parameters.AddWithValue("sdt", nguoiDung.sdt);
            sqlCMD.Parameters.AddWithValue("maTK", nguoiDung.MaTK);
            sqlCMD.Parameters.AddWithValue("Tien", nguoiDung.Tien);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        public bool Bus_xoaNguoiDung(string maND)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboQLXoaNguoiDung";
            sqlCMD.Parameters.AddWithValue("maNguoiDung", maND);
            sqlCMD.Connection = CONECT.DBKETNET();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;

        }
        public bool Bus_xoaNguoiDung_MuaVe(string maND)
        {
            Chung("dboXoaVeNguoiDungDaMua");
            sqlCMD.Parameters.AddWithValue("maNguoiDung", maND);
            Concect();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;

        }
        public SqlDataReader timKiemNguoiDung(string tenNguoiDung)
        {
            Chung("dboTimKiemNguoiDung");
            sqlCMD.Parameters.AddWithValue("tenVe", $"%{tenNguoiDung}%");
            Concect();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Tiện ich Hiển Thị Người Dùng
        public static SqlDataReader hienThiNguoiDung()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboHienThiNguoiDung";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader() ;
            return reader;
        }
        // Tạo báo cáo
        public DataTable baoCao ()
        {
            Chung("dboBaoCaoNguoiDungMuaVe");
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt;
        }
    }
}
