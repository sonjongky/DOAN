using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAO;

namespace DAO
{
    public class TableDAO : ConnectionToSql
    {
        private static TableDAO _Instance;

        public static TableDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TableDAO();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private TableDAO()
        {

        }
        public LinkedList<int> GetIDTable()
        {
            LinkedList<int> list = new LinkedList<int>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select id_table From Ban";
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id_table = reader.GetInt32(0);
                                list.AddLast(id_table);
                            }
                        }
                    }
                    connection.Close();
                    return list;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
                return null;
            }
        }

        public void FillComboBox(ComboBox combobox)
        {
            combobox.Items.Add("Mua về"); // ko có bàn nào
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select id_table From Ban";
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id_table = reader.GetInt32(0);
                            combobox.Items.Add(id_table);
                        }
                    }
                }
                combobox.Items.Add("");
                combobox.Items.Remove(0);
                connection.Close();
            }
        }
    }
}
