using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoVaiOperate
{
    internal class SqlHelper
    {
        private string server;
        private string database;
        private string userId;
        private string password;
        private string port;
        private string SqlConnectionString;
        private SqlConnection sqlConnection;
        public SqlHelper()
        {
            /*server = "ADMIN-PC\\SQLEXPRESS";
            database = "vanTuongDummy";
            SqlConnectionString = $"Server={server};Database={database};Integrated Security=True;TrustServerCertificate=True;Connection Timeout=30";*/

            server = VanTuongSql.ipAddress;
            port = "1433";
            database = "vanTuong";
            userId = "ngocAnh";
            password = "@Marx05051818b";
            SqlConnectionString = $"Server={server},{port};Database={database};User Id={userId};Password={password};TrustServerCertificate=True;";
        }
        public SqlConnection getConnection()
        {
            sqlConnection = new SqlConnection(SqlConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
