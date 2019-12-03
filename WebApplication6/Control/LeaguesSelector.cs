using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class LeaguesSelector
    {
        public List<Leagues> showResults(int uid) {
            Participants a = new Participants();
            a.userid = uid;
            return a.getJoinLeagues();
        }
    }
}