using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Matches
    {
        public int matchid { get; set; }
        public string matchname { get; set; }


        public List<Matches> getMatch() {
            string x = "select a.MatchID,b.TypeName from Matches a,MatchType b where a.MatchType = b.TypeID";
            SqlCommand a = new SqlCommand(x, connect.get());
            List<Matches> list = new List<Matches>();
            SqlDataReader reader = a.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Matches() {matchid=Convert.ToInt32(reader[0]),matchname= reader[1].ToString() });
            }
            reader.Close();
            return list;
        }
    }
}