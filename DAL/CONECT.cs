    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CONECT
    {
        public static SqlConnection DBKETNET()
        {
            string strCon = @"Data Source=DESKTOP-T04T4KL\SQLEXPRESS;Initial Catalog=QLBENXE;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(strCon);
            sqlcon.Open();
            return sqlcon;
        }
    }
}
