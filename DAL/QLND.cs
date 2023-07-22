using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLND
    {
        private string _maND;
        private string _maQL;

        public string MaND { get => _maND; set => _maND = value; }
        public string MaQL { get => _maQL; set => _maQL = value; }
        public QLND()
        {

        }
        public QLND(string MaVE, string MaQL)
        {
            this.MaND = MaVE;
            this.MaQL = MaQL;
        }
    }
}
