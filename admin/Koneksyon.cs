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
            con = new SqlConnection("");
            return con;
        }
    }
    /**@author Darwin
     Laptop: 
    */

    /**@author Gavin
     Laptop: Data Source=LAPTOP-2GIQGPEP;Initial Catalog=DormDTB;Integrated Security=True;Encrypt=False
    */

    /**@author Marga
     Laptop: 
    */
}
