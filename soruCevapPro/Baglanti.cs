using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace soruCevapPro
{
    internal class Baglanti
    {
        public static SqlConnection baglan ()
        {
            SqlConnection con = new SqlConnection("server = .; initial catalog = scDB; integrated security = sspi");
            con.Open();
            return con; 
        }
    }
}
