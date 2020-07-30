using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class LeaguesProxy
    {
        public int LeagueID { get; set; }
        public string Tourname { get; set; }
        public string LeagueName { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int userid { get; set; }
        public int sum { get; set; }

        public List<Leagues> showLeagues()
        { //proxy
            string x = "";
            if (userid == 0)
            {
                x = "select top 3 a.LeagueName,b.TournamentName,a.LeagueID from League a,Tournament b where a.TournamentID = b.TournamentID";
            }
            else
            {
                x = $"select top 3 a.LeagueName,b.TournamentName,a.LeagueID from League a,Tournament b where a.TournamentID = b.TournamentID and Userid = {userid}";
            }
            SqlCommand com = new SqlCommand(x, connect.get());
            SqlDataReader read = com.ExecuteReader();
            List<Leagues> list = new List<Leagues>();
            while (read.Read())
            {
                list.Add(new Leagues() { LeagueName = read[0].ToString(), Tourname = read[1].ToString(), LeagueID = Convert.ToInt32(read[2]) });
            }
            read.Close();
            return list;
        }

    }
}