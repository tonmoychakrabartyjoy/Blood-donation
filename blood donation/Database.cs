using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace blood_donation
{
    internal class Database
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=TONMOY\SQLEXPRESS;Initial Catalog=TCJ_Academy;Integrated Security=True; TrustServerCertificate=True;");

    }
}
