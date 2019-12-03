using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class ShowAnnoucements
    {
        public List<Annoucements> listAnn(int userid) {
            return new Annoucements().getAnnounce(userid);
        }
    }
}