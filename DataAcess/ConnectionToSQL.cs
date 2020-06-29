using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public abstract class ConnectionToSql // dung de ke thua
    {   
        private readonly string connectionstring; // ko can khoi tao truoc , khi gan gia tri thi sau do khong thay doi duoc 
        public ConnectionToSql()
        {
            connectionstring = "Data Source=PV;Initial Catalog=Coffee_Management;Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
