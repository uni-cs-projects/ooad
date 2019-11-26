using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Teams
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public List<Teams> showTeams() {
            SqlCommand a = new SqlCommand("select * from Team",connect.get());
            List<Teams> teams = new List<Teams>();
            SqlDataReader read = a.ExecuteReader();
            while (read.Read())
            {
                teams.Add(new Teams() {TeamID = Convert.ToInt32(read[0]),TeamName = read[1].ToString() });
            }
            read.Close();
            return teams;
        }
    }
}