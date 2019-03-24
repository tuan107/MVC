using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MVCTest.DAL
{
    public class DALItem:Dbconnect
    {
        public static List<Models.Item> getSp()
        {
            if (con != null && con.State == ConnectionState.Closed) con.Open();// mở kết nối
            List<Models.Item> l = new List<Models.Item>();
            SqlCommand cmd = new SqlCommand("Select * from sanPham",con);

            

            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read() && rd!=null)
            {
                Models.Item item = new Models.Item();
                item.Id = rd.GetInt32(0);
                item.Ten = rd.GetString(1);
                item.Img = rd.GetString(2);
                l.Add(item);
            }
            rd.Close(); // <- too easy to forget
            rd.Dispose(); // <- too easy to forget
            con.Close();
            return l;
        }

        public static void insert(Models.Item it)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into sanPham(img,ten) values('"+it.Img+"','"+it.Ten+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void update(Models.Item it)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update sanPham set img = '" + it.Img + "' , ten = '" + it.Ten + "' where id = '" + it.Id + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}