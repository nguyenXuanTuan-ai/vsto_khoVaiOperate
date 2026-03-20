using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoVaiOperate
{
    internal class BasicSqlFunction
    {
        public List<string> GetStringColumnFromQuery(string query, string columnName)
        {
            SqlHelper sqlHelper = new SqlHelper();
            List<string> results = new List<string>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                conn = sqlHelper.getConnection();
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[columnName] != DBNull.Value)
                    {
                        results.Add(reader[columnName].ToString());
                    }
                    else
                    {
                        results.Add(null);
                    }
                }
                CommonInternalFunction.informConnectionStable();
            }
            finally
            {
                if (reader != null && reader.IsClosed == false)
                    reader.Close();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return results;
        }

        public List<int> GetIntegerColumnFromQuery(string query, string columnName)
        {
            SqlHelper sqlHelper = new SqlHelper();
            List<int> results = new List<int>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                conn = sqlHelper.getConnection();
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    object value = reader[columnName];
                    int intValue = (value != DBNull.Value) ? Convert.ToInt32(value) : 0;
                    results.Add(intValue);
                }
                CommonInternalFunction.informConnectionStable();
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (cmd != null)
                    cmd.Dispose();
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return results;
        }

        public List<double> GetFloatColumnFromQuery(string query, string columnName)
        {
            SqlHelper sqlHelper = new SqlHelper();
            List<double> results = new List<double>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                conn = sqlHelper.getConnection();
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    object value = reader[columnName];
                    double floatValue = (value != DBNull.Value) ? Convert.ToDouble(value) : 0.0;
                    results.Add(floatValue);
                }
                CommonInternalFunction.informConnectionStable();
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return results;
        }

        public List<object> getListObjectColumnFromQuery(string query, string columnName)
        {
            SqlHelper sqlHelper = new SqlHelper();
            List<object> results = new List<object>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                conn = sqlHelper.getConnection();
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    object value = reader[columnName];
                    results.Add(value);
                }
                CommonInternalFunction.informConnectionStable();
            }
            finally
            {

            }
            return results;
        }

        public void executeQuery(string query)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = sqlHelper.getConnection();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                CommonInternalFunction.informConnectionStable();
            }
            finally
            {
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void readWholeSqlTable(string query, List<string> listOfColumn, Dictionary<string, List<object>> sqlTable)
        {
            sqlTable.Clear();
            SqlHelper sqlHelper = new SqlHelper();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                conn = sqlHelper.getConnection();
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                foreach (var column in listOfColumn)
                {
                    sqlTable[column] = new List<object>();
                }
                while (reader.Read())
                {
                    foreach (var column in listOfColumn)
                    {
                        object value = reader[column];
                        sqlTable[column].Add(value == DBNull.Value ? null : value);
                    }
                }
                CommonInternalFunction.informConnectionStable();
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
