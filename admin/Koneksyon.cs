using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Laundry___Dormitory.admin
{
    internal class Koneksyon
    {
        SqlConnection con;

        public SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=DLMG;Initial Catalog=DormDTB;Integrated Security=True;Encrypt=False");
            return con;
        }
    }
}
