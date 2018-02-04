using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace practice_c_web_net_01.database
{
    public class Connect
    {
        private SqlConnection connection;

        public Connect()
        {
            connection = new SqlConnection("Data source=.;Initial Catalog=dev7_users;Integrated Security=true");
        }

        private void Open()
        {
            connection.Open();
        }

        private void Close()
        {
            connection.Close();
        }

        public DataTable GetData(string sql)
        {
            Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            Close();
            sda.Fill(dt);
            return dt;
        }

        public bool UpdateData(string sql)
        {
            Open();
            SqlCommand sc = new SqlCommand(sql, connection);
            int rows = sc.ExecuteNonQuery();
            Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }
    }
}