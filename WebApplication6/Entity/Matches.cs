using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Matches
    {
        public int matchid { get; set; }
        public string matchname { get; set; }

        public SimpleMatchFactory obj;

        public Matches(SimpleMatchFactory obj)
        {
            this.obj = obj;
        }

        public Matches()
        {
        }


        public List<Matches> getMatch(string type) {
            Match match;
            match = obj.getMatch(type);
            return match.getMatch();
        }
    }
}