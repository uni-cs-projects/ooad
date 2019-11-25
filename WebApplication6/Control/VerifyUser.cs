using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class VerifyUser
    {
        public int validateUser(string _eml,string _pwd) {
            Users check = new Users();
            if (check.checkUser(_eml,_pwd))
            {
                FormsAuthentication.SetAuthCookie(check.name, false);
                return check.Userid;
            }
            return 0;

        }
    }
}