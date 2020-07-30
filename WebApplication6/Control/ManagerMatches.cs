using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class ManagerMatches
    {
        public List<Matches> getMatchList() {
            SimpleMatchFactory ab = new SimpleMatchFactory();
            return new Matches(ab).getMatch("T20"); // factory
        }
    }
}