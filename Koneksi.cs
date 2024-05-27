using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace kasir
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "DATA Source = DESKTOP-GHJ83K6\\SERVER05; initial catalog=DB_Kasir;integrated security=true";
            return Conn;
        }
    }
}
