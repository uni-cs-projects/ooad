﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication6.Entity
{
    public class General : PlayerSearchBehaviour
    {

        public List<Players> getPlayers(int Teamid, int playerType)
        {
            List<Players> list = new List<Players>();
            SqlCommand com = new SqlCommand("select * from Player", connect.get());
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Players() { playerid = Convert.ToInt32(reader[0]), Teamid = Convert.ToInt32(reader[1]), playerName = reader[2].ToString(), playerType = Convert.ToInt32(reader[3]), playerhand = reader[4].ToString() });
            }
            reader.Close();
            return list;
        }
    }
}