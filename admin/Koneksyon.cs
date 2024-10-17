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
            // e change rani 
            con = new SqlConnection("Data Source=LAPTOP-2GIQGPEP;Initial Catalog=DormDTB;Integrated Security=True;Encrypt=False");
            return con;
        }
    }
    /**@author Darwin
     Laptop: Data Source=DLMG;Initial Catalog=DormDB;Integrated Security=True;Encrypt=False
    */

    /**@author Gavin
     Laptop: Data Source=LAPTOP-2GIQGPEP;Initial Catalog=DormDTB;Integrated Security=True;Encrypt=False
    */

    /**@author Marga
     Laptop: Data Source=LAPTOP-SPR4SQLD;Initial Catalog=DormDTB;Integrated Security=True;Encrypt=False
    */
}
