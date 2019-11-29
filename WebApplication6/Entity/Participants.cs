using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Participants
    {
        public int userid { get; set; }
        public int Teamid { get; set; }
        public int Leagueid { get; set; }
       

        public void addPartiTeam(int Userid, int LeagueID, string TeamName)
        {
            string x = $"insert into UserTeam Values({Userid},{LeagueID},'{TeamName}')";
            SqlCommand a = new SqlCommand(x, connect.get());
            a.ExecuteNonQuery();
        }

        public void addUserPlayers(int userid, int legueid, List<string> ab)
        {
            int UTeamid = 0;
            string x = $"select UserTeamID from UserTeam where UserID={userid} and LeagueID={legueid}";
            SqlCommand a = new SqlCommand(x, connect.get());
            SqlDataReader reader = a.ExecuteReader();
            while (reader.Read())
            {
                UTeamid = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            foreach (string item in ab)
            {
                x = $"insert into UserTeamPlayers values({UTeamid},'{item}')";
                a = new SqlCommand(x, connect.get());
                a.ExecuteNonQuery();
            }
          
            }

        public List<Leagues> getJoinLeagues() {
            string x = $"select a.LeagueName,c.TournamentName from League a,UserTeam b,Tournament c where b.LeagueID = a.LeagueID and a.TournamentID = c.TournamentID and b.UserID ={userid}";
            List<Leagues> list = new List<Leagues>();
            SqlCommand a = new SqlCommand(x, connect.get());
            SqlDataReader reader = a.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Leagues() {LeagueName = reader[0].ToString(),Tourname=reader[1].ToString() });
            }
            reader.Close();
            return list;
        }
        }

    }
