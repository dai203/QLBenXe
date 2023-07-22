using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLTK
    {
        private string _maTK;
        private string _maQL;

        public string MaTK { get => _maTK; set => _maTK = value; }
        public string MaQL { get => _maQL; set => _maQL = value; }
        public QLTK() { }
        public QLTK(string MaTK, string MaQL)
        {
            this.MaTK = MaTK;
            this.MaQL = MaQL;
        }
    }
}
