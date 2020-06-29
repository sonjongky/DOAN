using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DataProvider : ConnectionToSql
    {
        private static DataProvider _Instance;

        public static DataProvider Instance 
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataProvider();
                }
                return _Instance;
            }
            private set => _Instance = value; 
        }
        private DataProvider()
        {

        }

        public void ExecuteDB(string query)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }   
        }
        public DataTable GetRecord(string query)
        {
            DataTable table = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = query;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            table.Load(reader);
                        }
                    }
                    connection.Close();
                }
                return table;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
                return null;
            }
        }
        public string GetString(string query)
        {
            string st = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = query;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            try
                            {
                                st = reader.GetString(0);
                            }
                            catch(Exception)
                            {
                                st = Convert.ToString(reader.GetInt32(0));
                            }
                        }
                    }
                    connection.Close();
                    return st;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
                return null;
            }
        }
    }
}
