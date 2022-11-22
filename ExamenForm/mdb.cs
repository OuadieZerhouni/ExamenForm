using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExamenForm
{
    internal class mdb
    {
        static string chaine = @"Data Source=localhost;Initial Catalog=BDGED_copy;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        
    }
}
