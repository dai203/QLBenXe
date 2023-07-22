    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan
    {
        private string _maTK;
        private string _tenTK;
        private string _matKhau;

        public string MaTK { get => _maTK; set => _maTK = value; }
        public string TenTK { get => _tenTK; set => _tenTK = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public TaiKhoan() { }
        public TaiKhoan(string MaTK, string tenTK, string MatKhau)
        {
            this.MaTK = MaTK;
            this.TenTK = tenTK;
            this.MatKhau = MatKhau;
        }
    }
}
