using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VE
    {
        private string _maVe;
        private string _tenXe;
        private string _loaiVe;
        private string _giaVe;
        private string _maXe;
        public VE() { }
        
        public string MaVe { get => _maVe; set => _maVe = value; }
        public string TenXe { get => _tenXe; set => _tenXe = value; }
        public string LoaiVe { get => _loaiVe; set => _loaiVe = value; }
        public string GiaVe { get => _giaVe; set => _giaVe = value; }
        public string MaXe { get => _maXe; set => _maXe = value; }

        public VE(string MaVe, string TenXe,  string LoaiVe, string GiaVe, string MaXe)
        {
            this.MaVe = MaVe;
            this.TenXe = TenXe;
            this.LoaiVe = LoaiVe;
            this.GiaVe = GiaVe;
            this.MaXe = MaXe;
        }
    }
}
