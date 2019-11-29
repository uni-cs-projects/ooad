using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Entity
{
    public class Tounaments
    {
        public int TourID { get; set; }
        public string tourname { get; set; }
        public int tourtype { get; set; }

        public List<Tounaments> get()
        {
            string x = "select * from Tournament";
            SqlCommand a = new SqlCommand(x,connect.get());
            SqlDataReader reader = a.ExecuteReader();
            List<Tounaments> list = new List<Tounaments>();
            while (reader.Read())
            {
                list.Add(new Tounaments() {TourID=Convert.ToInt32(reader[0]),tourname=reader[1].ToString(),tourtype=Convert.ToInt32(reader[2]) });
            }
            reader.Close();
            return list;
        }
    }
}