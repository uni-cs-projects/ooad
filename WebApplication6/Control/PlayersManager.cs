using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class PlayersManager
    {
        public List<Players> getPlayer() {
            return new Players().getPlayers();

        }

        public List<Players> getPlayer(int teamid,int playertype)
        {
            Players a = new Players();
            a.Teamid = teamid;
            a.playerType = playertype;
            return a.getPlayers();

        }

        

    }
}