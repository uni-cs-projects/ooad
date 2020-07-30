using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication6
{
    public class ConnectionAdapter
    {
        public SqlConnection createConnection(SqlConnection ab)
        {
            SqlConnection connect = ab; //Singleton
            if (connect == null)
            {
                connect = new SqlConnection();
                connect.ConnectionString = "Data Source=SHAZAD\\SQLEXPRESS;Initial Catalog=FantasyLeagueDB;Integrated Security=True;";
                connect.Open();

            }
            return connect;

        }
    }
}