using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class LeaguesManager
    {

        public void createLeague(int _tid,string leagueName,DateTime sdate,DateTime edate,int userid) {
            new Leagues(_tid,leagueName,sdate,edate,userid);
            
        }

        public void deleteLeague() { }

   
    }
}