using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Points
    {
        public int matchid { get; set; }
        public int playerid { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public int sixes { get; set; }
        public int fours { get; set; }


        public void add() {
            string x = $"insert into MatchResult values({matchid},{playerid},{runs},{wickets},{sixes},{fours})";
            SqlCommand a = new SqlCommand(x, connect.get());
            a.ExecuteNonQuery();
        }

        public int totalPoints(int uid,int lid) {
            string x = $"select sum(c.Runs)+sum(c.Wickets)+sum(c.Fours)+sum(c.Sixes) from MatchResult c where c.PlayerID in (select a.playerid from UserTeamPlayers a,UserTeam b where a.UserTeamID = (select UserTeamID from UserTeam where UserID = {uid} and LeagueID = {lid}))";
            SqlCommand a = new SqlCommand(x, connect.get());
            SqlDataReader reader = a.ExecuteReader();
            int ret = 0;
            while (reader.Read())
            {
                ret = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            return ret;

        }
    }
}