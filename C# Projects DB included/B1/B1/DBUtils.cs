using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace B1
{
    class DBUtils
    {
        public static SqlConnection getConnection()
        {//konkcija
            string connectionstring = @"Data Source = DESKTOP-KIAEOL7;Initial Catalog = B1; Integrated Security = SSPI; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            return cnn;
        }
        public static void newTableRecord(string table, Dictionary<string, object> parameters)
        {//insert
            string sql = "INSERT INTO " + table;
            string columns = "";
            string values = "";
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if ("".Equals(columns))
                {
                    columns = "(" + parameter.Key;
                    values = "(@" + parameter.Key;
                }
                else
                {
                    columns = columns + "," + parameter.Key;
                    values = values + ",@" + parameter.Key;
                }

            }

            columns = columns + ")";
            values = values + ")";
            sql = sql + " " + columns + " VALUES " + values;
            Console.WriteLine("sql - " + sql);
            SqlConnection conn = getConnection();
            SqlCommand command = new SqlCommand(sql, conn);
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                command.Parameters.Add("@" + parameter.Key, parameter.Value);
            }
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static List<DBRecord> getRecordsFromDB(string sql, Dictionary<string, object> parameters)
        {
            List<DBRecord> result = new List<DBRecord>();
            SqlConnection conn = getConnection();
            SqlCommand command = new SqlCommand("@" + sql, conn);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(parameter.Key, parameter.Value);
                }
            }
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DBRecord r = new DBRecord();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        r.addColumn(dr.GetName(i), dr.GetValue(i));
                    }

                }
            }
            return result;
        }
    }
}
