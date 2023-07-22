using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PERSON
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string diaChi {
            get; set;
        }
        public string sdt { get; set; }
        public PERSON() {
        }
        public PERSON(string ma, string ten, string diaChi, string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
    }
}
