using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public static class connect
    {
        public static SqlConnection ab;
        public static SqlConnection get() {
            return new ConnectionAdapter().createConnection(ab);
        }
    }
}