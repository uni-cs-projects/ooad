using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Leagues
    {
        public int LeagueID { get; set; }
        public string Tourname { get; set; }
        public string LeagueName { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }

        public Leagues() {

        }
        public Leagues(string _torname,string _lename,string _strdate,string enddate)
        {
            string x = $"insert into League values('{_torname}','{_lename}','{_strdate}','{enddate}')";
            SqlCommand a = new SqlCommand(x, connect.get());
            a.ExecuteNonQuery();
        }

        public List<Leagues> showLeagues() {
            SqlCommand com = new SqlCommand("select a.LeagueName,b.TournamentName from League a,Tournament b where a.TournamentID = b.TournamentID", connect.get());
            SqlDataReader read = com.ExecuteReader();
            List<Leagues> list = new List<Leagues>();
            while (read.Read())
            {
                list.Add(new Leagues() { LeagueName=read[0].ToString(),Tourname=read[1].ToString()});
            }
            read.Close();
            return list;
        }
    }
}