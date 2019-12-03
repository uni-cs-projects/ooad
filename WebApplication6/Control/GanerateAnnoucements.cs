using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class GanerateAnnoucements
    {
        public void genAnn(int lid,string msg) {
            Annoucements a = new Annoucements();
            a.leagueid = lid;
            a.msg = msg;
            a.date = DateTime.Now.ToString();
            a.makeAnnoucements();
        }
    }
}