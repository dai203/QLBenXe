using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLVE
    {
        private string _maQL;
        private string _maVE;

        public string MaQL { get => _maQL; set => _maQL = value; }
        public string MaVE { get => _maVE; set => _maVE = value; }
        public QLVE()
        {

        }
        public QLVE(string MaVE, string MaQL)
        {
            this.MaVE = MaVE;
            this.MaQL = MaQL;
        }
    }
}
