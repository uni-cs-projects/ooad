using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class ParticipantsManager
    {
        public void addTeam(int userid,int leagueid, string name,List<string> players) {
            Participants a = new Participants();
            a.addPartiTeam(userid, leagueid, name);
            a.addUserPlayers(userid,leagueid,players);
        }

        public List<Leagues> JoinedLeagues(int uid) {
            Participants a = new Participants();
            a.userid = uid;
            return a.getJoinLeagues();
        }

        public void sendInvite(int sid,int rid,int lid) {
            new Participants().invite(sid, rid, lid);
        }
    }
}