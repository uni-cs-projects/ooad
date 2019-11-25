using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class ShowLeagues
    {
        public List<Leagues> listLeague() {
            Leagues items = new Leagues();
            return items.showLeagues();
        }
    }
}