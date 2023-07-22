using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface INGUOIDUNG 
    {
        bool dangNhap(string tentk, string matkhau);
        bool dangKy(TaiKhoan taiKhoan);
        bool dangKyThongTin(NguoiDung nguoiDung);
        string traVeMaTK(string tenTK, string matKhau);
        string quenMatKhau(string tenTK);

        bool checkTK(string tenTK);
    }
    public class NguoiDung : PERSON, INGUOIDUNG
    {
        private string _maTK; 
        private List<string> tenTK = new List<string>();
        private List<string> maTK = new List<string>();
        private List<string> maNguoiDung = new List<string>();
        private ArrayList matKhau = new ArrayList();
        private float _tien;
        public string MaTK { get => _maTK; set => _maTK = value; }
        public float Tien { get => _tien; set => _tien = value; }

        public NguoiDung() { }
        public NguoiDung(string ma, string ten, string diaChi, string sdt, string MaTK, float Tien) : base(ma, ten, diaChi, sdt) { 
            this.MaTK = MaTK;
            this.Tien = Tien;
        }

        public void layTenTK()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayTenTaiKhoan";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                tenTK.Add(reader.GetString(0));
            }
            reader.Close();
        }
        public void sua(QuanLy obj)
        {
            throw new NotImplementedException();
        }

        public void them(QuanLy obj)
        {
            throw new NotImplementedException();
        }

        public void timKiem(QuanLy obj)
        {
            throw new NotImplementedException();
        }

        public void xoa(QuanLy obj)
        {
            throw new NotImplementedException();
        }
        // chức năng Người Dùng3
        public void layMatKhau()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboGetMatKhau";
            sqlCMD.Connection =  CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                matKhau.Add(reader.GetString(0));
            }
            reader.Close();
        }
        public bool dangNhap(string tentk, string matkhau)
        {
            layTenTK();
            layMatKhau();
            int cnt = 0;
            foreach(string i in tenTK)
            {
                if (i == tentk) {
                    cnt++;
                    break;
                }
            }
            foreach (string i in matKhau)
            {
                if (i ==  matkhau)
                {
                    cnt++;
                    break;
                }
            }
            if (cnt == 2)
            {
                return true;
            }
            return false;

        }
        // Người dùng đăng ký tài khoản
        
        public bool dangKy(TaiKhoan taiKhoan)
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
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboDangKyTaiKhoan";
            sqlCMD.Parameters.AddWithValue("maTK", x);
            sqlCMD.Parameters.AddWithValue("tenTK", taiKhoan.TenTK);
            sqlCMD.Parameters.AddWithValue("matKhau", taiKhoan.MatKhau);
            sqlCMD.Connection = CONECT.DBKETNET();
            if (sqlCMD.ExecuteNonQuery() > 0 )
            {
                return true;
            }else
            {
                return false;
            }
        }
        // Lấy Mã TK
        public void getMaTK()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaTK";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                maTK.Add(reader.GetString(0));
            }
            reader.Close();
        }
        // Lấy Mã Người Dùng
        public void getMaNguoiDung()
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaNguoiDung";
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while (reader.Read())
            {
                maNguoiDung.Add(reader.GetString(0));
            }
            reader.Close();
        }
        // Đăng Ký Thông Tin Người Dùng
        public bool dangKyThongTin(NguoiDung nguoiDung)
        {
            getMaNguoiDung();
            back:
            Random random = new Random();
            string x =  "KH"+random.Next(1000);
            foreach(string i in maNguoiDung)
            {
                if (i == x)
                {
                    goto back;
                }
            }
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboDangKyThongTinNguoiDung";
            sqlCMD.Parameters.AddWithValue("maND", x);
            sqlCMD.Parameters.AddWithValue("tenNguoiDung", nguoiDung.ten);
            sqlCMD.Parameters.AddWithValue("diaChi", nguoiDung.diaChi);
            sqlCMD.Parameters.AddWithValue("sdt", nguoiDung.sdt);
            sqlCMD.Parameters.AddWithValue("maTK", nguoiDung.MaTK);
            sqlCMD.Parameters.AddWithValue("Tien", nguoiDung.Tien);
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
        // Kiểm Tra TK
        public bool checkTK(string ten)
        {
            layTenTK();
            foreach(string i in tenTK)
            {
                if (i == ten)
                {
                    return false;
                }
            }
            return true;
        }
        // Trả Về Mã Tk
        public string traVeMaTK(string tenTK, string matKhau)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaTaiKhoan";
            sqlCMD.Parameters.AddWithValue("tenTK", tenTK);
            sqlCMD.Parameters.AddWithValue("matKhau", matKhau);
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                return reader.GetString(0);
            }
            reader.Close();
            return "null";
        }
        // Lấy Mã TK
        public string layMaTK(string ten, string mk)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboNguoiDungLayMaTK";
            sqlCMD.Parameters.AddWithValue("@tenTK", ten);
            sqlCMD.Parameters.AddWithValue("@matKhau", mk);
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                return reader.GetString(0);
            }
            return "";
        }
        // Quên Mật Khẩu
        public string quenMatKhau(string tenTK)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboQuenMatKhau";
            sqlCMD.Connection= CONECT.DBKETNET();
            sqlCMD.Parameters.AddWithValue("tenTK", tenTK);
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                return reader.GetString(0);
            }
            reader.Close();
            return "null";
        }
        // Lấy Thông Tin Tài Khoản
        public SqlDataReader layThongTin(string maTK)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaThongTinTK";
            sqlCMD.Parameters.AddWithValue("@maTK", maTK);
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Cập Nhật Thông Tin Người Dùng
        public bool CapNhatThongTin(string tenND, string diaChi, string sdt, string maND)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboCapNhatThongTin";
            sqlCMD.Parameters.AddWithValue("@tenND", tenND);
            sqlCMD.Parameters.AddWithValue("@diaChi", diaChi);
            sqlCMD.Parameters.AddWithValue("@sdt", sdt);
            sqlCMD.Parameters.AddWithValue("@maND", maND);
            sqlCMD.Connection = CONECT.DBKETNET();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        // Lấy mã người dùng từ TK
        public string maNguoiDungTuMaTK(string maTK)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboLayMaNguoiDungTuMaTK";
            sqlCMD.Parameters.AddWithValue("@maTK", maTK);
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while (reader.Read())
            {
                return reader.GetString(0);
            }
            return "";
        }
        // Người Dùng Mua Vé
        public bool NguoiDungMuaVe(string maVe, string maND)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboMuaVe";
            sqlCMD.Parameters.AddWithValue("@maVe", maVe);
            sqlCMD.Parameters.AddWithValue("@maND", maND);
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
        // Hiển Thị Vé
        public SqlDataReader HienThiVeNguoiDungDaMua(string maND)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboHienThiVeNguoiDungDoMua";
            sqlCMD.Parameters.AddWithValue("@maND", maND);
            sqlCMD.Connection = CONECT.DBKETNET();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        // Người Dùng Bỏ Mua Vé
        public bool boMuaVe(string maND, string maVe)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCMD.CommandText = "dboNguoiDungBoKhongMuaVe";
            sqlCMD.Parameters.AddWithValue("@maVe", maVe);
            sqlCMD.Parameters.AddWithValue("@maND", maND);
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
    }
}
