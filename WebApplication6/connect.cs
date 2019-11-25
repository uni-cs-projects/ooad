using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public static class connect
    {
        public static SqlConnection ab;
        public static SqlConnection get() {
            if (ab == null)
            {
                ab = new SqlConnection();
                ab.ConnectionString = "Data Source=DESKTOP-O3SH4TA\\SQLEXPRESS;Initial Catalog=FantasyLeagueDB;Integrated Security=True;";
                ab.Open();

            }
            return ab;
        }
    }
}