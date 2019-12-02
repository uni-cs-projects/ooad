using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Players
    {
        public string playerName { get; set; }
        public int playerid { get; set; }
        public int Teamid { get; set; }
        public string TypeName { get; set; }
        public int playerType { get; set; }
        public object SqlComman { get; private set; }
        public string playerhand { get; set; }

        public List<Players> getPlayers() {
            string x = "";
            if(Teamid == 0 && playerType == 0)
            {
                x = "select * from Player";
            }
            else if (Teamid == 0)
            {
                x = $"select * from Player where PlayerType={playerType}";
            }
            else if (playerType == 0)
            {
                x = $"select * from Player where TeamID={Teamid}";
            }
            else
            {
                x = $"select * from Player where TeamID={Teamid} and PlayerType={playerType}";
            }
            List<Players> list = new List<Players>();
            SqlCommand com = new SqlCommand(x,connect.get());
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Players() { playerid = Convert.ToInt32(reader[0]),Teamid=Convert.ToInt32(reader[1]),playerName=reader[2].ToString(),playerType=Convert.ToInt32(reader[3]),playerhand=reader[4].ToString() });
            }
            reader.Close();
            return list;
        }

        public List<Players> getPlayertype()
        {
            string x = "select * from PlayerType";
       
            List<Players> list = new List<Players>();
            SqlCommand com = new SqlCommand(x, connect.get());
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Players() {playerType = Convert.ToInt32(reader[0]),TypeName=reader[1].ToString() });
            }
            reader.Close();
            return list;
        }
    }
}