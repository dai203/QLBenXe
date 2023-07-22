using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XE
    {
        private string _maXE;
        private string _soCho;
        private string _tenXe;
        private string _loaiXe;
        private string _bienSo;
        private string _thoiGianDiChuyen;
        private string _tenNguoiLai;
        private string _sdtNguoiLai;
        public string MaXE { get => _maXE; set => _maXE = value; }
        public string SoCho { get => _soCho; set => _soCho = value; }
        public string TenXe { get => _tenXe; set => _tenXe = value; }
        public string LoaiXe { get => _loaiXe; set => _loaiXe = value; }
        public string BienSo { get => _bienSo; set => _bienSo = value; }
        public string ThoiGianDiChuyen { get => _thoiGianDiChuyen; set => _thoiGianDiChuyen = value; }
        public string TenNguoiLai { get => _tenNguoiLai; set => _tenNguoiLai = value; }
        public string SdtNguoiLai { get => _sdtNguoiLai; set => _sdtNguoiLai = value; }

        public XE() { }
        public XE(string MaXE, string SoCho, string TenXe, string LoaiXe, string BienSo, string ThoiGianDiChuyen, string tenNguoiLai, string sdtNguoiLai)
        {
            this.MaXE = MaXE;
            this.SoCho = SoCho;
            this.TenXe = TenXe;
            this.LoaiXe = LoaiXe;
            this.BienSo = BienSo;
            this.ThoiGianDiChuyen = ThoiGianDiChuyen;
            this.TenNguoiLai = tenNguoiLai;
            this.SdtNguoiLai = sdtNguoiLai;
        }
        
    }
}
