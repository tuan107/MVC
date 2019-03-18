using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCTest.DAL
{
    public class Dbconnect
    {
       static protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8T7FGTJ\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");

    }
}