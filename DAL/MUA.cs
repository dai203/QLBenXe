using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace DAL
{
    public class MUA
    {
        private string _maND;
        private string _maVe;
        public MUA() { }

        public string MaND { get => _maND; set => _maND = value; }
        public string MaVe { get => _maVe; set => _maVe = value; }
        public MUA(string maND, string maVe)
        {
            _maND = maND;
            _maVe = maVe;
        }
    }
}
