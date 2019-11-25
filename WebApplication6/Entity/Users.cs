using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace WebApplication6.Entity
{
    public class Users
    {
        public int Userid { get; set; }
        public string name { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }


        public bool checkUser(string _email,string _password) {
            SqlCommand ab = new SqlCommand("select * from users",connect.get());
            SqlDataReader read = ab.ExecuteReader();
            bool ret = false;
            while (read.Read())
            {
                if (_email == read[2].ToString() && _password == read[1].ToString())
                {
                    this.Userid = Convert.ToInt32(read[0]);
                    this.password = read[1].ToString();
                    this.email = read[2].ToString();
                    this.name = read[3].ToString();
                    ret = true;

                }
               
            }
            read.Close();
            return ret;
            
        }
        public void addUser() {
            string x = $"insert into Users values('{password}','{email}','{name}')";
            SqlCommand ab = new SqlCommand(x, connect.get());
            ab.ExecuteNonQuery();
        }
    }
}