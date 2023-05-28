using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAL
{
    public class DataProvider : IDataProvider
    {
        public DataProvider()
        {
        }

        private string c = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DATABASE\Database.mdf;Integrated Security=True";
        string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(c))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                connection.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int dt = 0;
            using (SqlConnection connection = new SqlConnection(c))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                dt = cmd.ExecuteNonQuery();
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                connection.Close();
            }
            return dt;
        }

        public object ExecuteScalar(string query)
        {
            object dt;
            using (SqlConnection connection = new SqlConnection(c))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                dt = cmd.ExecuteScalar();
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                connection.Close();
            }
            return dt;
        }
    }
}
