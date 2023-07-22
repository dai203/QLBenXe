using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLXE
    {
        private string _maQL;
        private string _maXE;

        public string MaQL { get => _maQL; set => _maQL = value; }
        public string MaXE { get => _maXE; set => _maXE = value; }
        public QLXE() { }
        public QLXE(string MaXE, string maQL)
        {
            this._maXE = MaXE;
            this._maQL = maQL;
        }
    }
}
