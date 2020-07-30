using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class SimpleMatchFactory
    {
        public Match getMatch(string type)
        {
            Match a = null;
            if (type.Equals("T20"))
            {
                a = new T20();
            }
            else if (type.Equals("ODI"))
            {
                a = new Odi();
            }
            else if (type.Equals("Test"))
            {
                a = new Test();
            }
            return a;
        }
    }
}