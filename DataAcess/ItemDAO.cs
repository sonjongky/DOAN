using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Drawing;
using System.IO;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace DAO
{
    public class ItemDAO : ConnectionToSql
    {
        private static ItemDAO _Instance;

        public static ItemDAO Instance 
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ItemDAO();
                }
                return _Instance;
            }
            private set => _Instance = value; 
        }
        private ItemDAO()
        {

        }
        public LinkedList<Item> GetItems()
        {
            LinkedList<Item> list_items = new LinkedList<Item>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select id_item,id_category,name,price,photo From Item";
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Item item = new Item();
                                item.ID_Item = reader.GetString(0);
                                item.ID_Category = reader.GetInt32(1);
                                item.Name = reader.GetString(2);
                                item.Price = reader.GetInt32(3);

                                long len = reader.GetBytes(4, 0, null, 0, 0);
                                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                                reader.GetBytes(4, 0, array, 0, System.Convert.ToInt32(len));
                                MemoryStream ms = new MemoryStream(array);
                                Bitmap bitmap = new Bitmap(ms);
                                item.Photo = bitmap;

                                list_items.AddLast(item);
                            }
                        }

                    }
                    connection.Close();
                }
                return list_items;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
                return null;
            }
            
        }

        public void Insert(string id_bill, string name_staff, string id_table, string name_item, string soluong)
        {
            string query = "EXEC Tao_Bill @id_bill = " + id_bill + " , @name_staff = N'" + name_staff + "' , @id_table = " + id_table + ", @name_item = N'" + name_item + "', @soluong = " + soluong;
            DataProvider.Instance.ExecuteDB(query);
        }

        public string Get_MAX_ID_Bill()
        {
            string id_bill = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT MAX(id_bill) FROM Bill";
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            id_bill = Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                    connection.Close();
                }
                return id_bill;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
                return id_bill;
            }
        }
    }
}
