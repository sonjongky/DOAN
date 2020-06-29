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
    public class RevenueDAO : ConnectionToSql
    {
        private static RevenueDAO _Instance;

        public static RevenueDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RevenueDAO();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private RevenueDAO()
        {

        }
        // Datagridview
        public DataTable Data_Bill(string year, string month , string day)
        {
            string dd, mm, yyyy;
            // year
            if (year == " ")
            {
                yyyy = "";
            }
            else yyyy = " YEAR(time) = '" + year + "'";
            // month
            if (month == " ")
            {
                mm = "";
            }
            else mm = " AND MONTH(time) = '" + month +"'";
            // day
            if (day == " ")
            {
                dd = "";
            }
            else dd = " AND DAY(time) = '" + day + "' ";
            string query = "SELECT id_bill , SUM(price) AS \"ToTal\", convert(char(20),time,100) AS \"Time\" From Bill WHERE" + yyyy + mm + dd + "GROUP BY id_bill , convert(char(20),time,100)";
            DataTable table = DataProvider.Instance.GetRecord(query);
            return table;
        }
        public DataTable Bill_Details(string id_bill)
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY name)  AS [STT], name,count, Bill.price FROM Item INNER JOIN Bill ON Item.id_item = Bill.id_item WHERE id_bill = " + id_bill + "ORDER BY name ASC";
            DataTable table = DataProvider.Instance.GetRecord(query);
            return table;
        }

        // Load combobox
        public void Fill_Child_ComboBox(ComboBox combobox)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * From Item ORDER BY name";
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable table = new DataTable();
                        if (reader.HasRows)
                        {
                            table.Load(reader);
                        }
                        combobox.DataSource = table;
                        combobox.DisplayMember = "name";
                        combobox.ValueMember = "id_item";
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        //  Get
        public string Get_NameStaff(string id_bill)
        {
            string query = "SELECT name_staff FROM Staff WHERE id_staff = ( SELECT DISTINCT id_staff FROM Bill WHERE id_bill = " + id_bill + " )";
            string name = DataProvider.Instance.GetString(query);
            return name;
        }
        public string Get_Table(string id_bill)
        {
            string query = "SELECT DISTINCT id_table FROM Bill WHERE id_bill = '" + id_bill + "'";
            string table = DataProvider.Instance.GetString(query);
            return table;
        }

        // Statement
        public void Insert(string id_bill, string name_staff, string id_table , string id_item, string soluong , string time)
        {
            string query = "EXEC Bill_Insert @id_bill = " + id_bill + " , @name_staff = N'" + name_staff + "' , @id_table = " + id_table + ", @id_item = '" + id_item + "', @soluong = " + soluong + ", @time = '" + time + "'";
            DataProvider.Instance.ExecuteDB(query);
        }
        public void Delete(string id_bill)
        {
            string query = "DELETE FROM Bill WHERE id_bill = '" + id_bill + "'";
            DataProvider.Instance.ExecuteDB(query);
        }
        public void Delete_Item(string name, string id_bill, string id_table)
        {
            string query = "EXEC Bill_Delete @ten = N'" + name + "', @id_bill = " + id_bill + ", @id_table = " + id_table + "";
            DataProvider.Instance.ExecuteDB(query);
        }
        public void Update(string id_item_update,string soluong,string id_bill, string id_table, string id_item)
        {
            string query = "UPDATE Bill SET id_item = '" + id_item_update + "' , count = " + soluong + " WHERE id_bill = " + id_bill + " AND id_table = " + id_table + " AND id_item = '" + id_item + "'";
            DataProvider.Instance.ExecuteDB(query);
        }
    }
}
