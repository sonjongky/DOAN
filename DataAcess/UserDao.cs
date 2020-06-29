        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DAO
{
    public class UserDAO: ConnectionToSql // User Data Acess Object
    {
        private static UserDAO _Instance;

        public static UserDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UserDAO();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private UserDAO()
        {

        }

        public bool Login(string user, string password)
        {
            try
            {
                // ham` using : sau khi thuc thi se giai pphong doi tuong trong using
                using (var connection = GetConnection()) // lay dia chi ket noi 
                {
                    connection.Open(); // mo ket noi
                    using (var command = new SqlCommand()) // tao cau lenh Sql
                    {
                        command.Connection = connection; // ket noi cau lenh den Sql
                        command.CommandText = "SELECT * FROM Account INNER JOIN Staff ON Account.username = Staff.username WHERE Account.username = @user AND pass= @pass"; // cau truy van
                        command.Parameters.AddWithValue("@user", user); // them gia tri tham so vao cau truy van
                        command.Parameters.AddWithValue("@pass", password); // them gia tri tham so vao cau truy van
                        command.CommandType = CommandType.Text; // thiet lap command
                        SqlDataReader reader = command.ExecuteReader(); // thuc thi 
                        if (reader.HasRows) // cho biết có dòng dữ liệu nào không
                        {
                            while (reader.Read())
                            {
                                UserCache.name = reader.GetString(4);
                                UserCache.permission = reader.GetInt32(2);
                            }
                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
                return false;
            }
        }
    }
}
