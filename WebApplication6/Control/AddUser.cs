using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class AddUser
    {
        public bool adder(string _name,string _pwd,string _email) {
            SqlCommand com = new SqlCommand("select Email from Users",connect.get());
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (_email == read[0].ToString())
                {
                    read.Close();
                    return false;
                }
            }
            read.Close();
            Users a = new Users();
            a.email = _email;
            a.name = _name;
            a.password = _pwd;
            a.addUser();
            return true;
        }
    }
}