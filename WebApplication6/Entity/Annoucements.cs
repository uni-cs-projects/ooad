using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Annoucements
    {
        public int leagueid { get; set; }
        public string msg { get; set; }
        public string leagueName { get; set; }
        public string date { get; set; }


        public List<Annoucements> getAnnounce(int uid) {

            string x = $"select a.LeagueName,b.message,b.leagueid,b.date from League a,Annoucements b,UserTeam c where b.leagueid = a.LeagueID and c.UserID = {uid} and c.LeagueID = b.leagueid";
            SqlCommand a = new SqlCommand(x, connect.get());
            SqlDataReader reader = a.ExecuteReader();
            List<Annoucements> list = new List<Annoucements>();
            while (reader.Read())
            {
                list.Add(new Annoucements() {leagueName=reader[0].ToString(),msg = reader[1].ToString(),leagueid=Convert.ToInt32(reader[2]),date=reader[3].ToString()});
            }
            reader.Close();
            return list;

        }

        public void makeAnnoucements() {
            string x = $"insert into Annoucements values({leagueid},'{msg}','{date}')";
            SqlCommand a = new SqlCommand(x, connect.get());
            a.ExecuteNonQuery();
        }
    }
}