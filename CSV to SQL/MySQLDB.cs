using MySql.Data.MySqlClient;
using System.Data;

namespace CSV_to_SQL
{
    public class MySQLDB
    {
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public bool isLoginOk;

        private string sql;

        List<Records> recordsList;

        public MySQLDB()
        {
        }

        bool sqlConnection(string _sql)
        {
            sql = _sql;
            try
            {
                string connection = (@"Data Source = localhost; Port = 3306 ; Initial Catalog = Test; User Id = Java; Password = 111111;");

                con = new MySqlConnection(connection);

                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Records> sqlRead(string _sql)
        {
            isLoginOk = sqlConnection(_sql);

            if (isLoginOk)
            {
                recordsList = new List<Records>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recordsList.Add(
                            new Records()
                            {
                                CustomerID = reader.GetInt32(0),
                                PerformanceID = reader.GetInt32(1),
                                Quantity = reader.GetInt32(2),
                                Price = Math.Round(reader.GetFloat(3),2),
                                Date = reader.GetString(4)
                            });
                    }
                }
            }
            con.Close();
            return recordsList;
        }

        public void sqlWrite(List<Records> records)
        {
            string _sql = "insert into Performance_DataRecords(CustomerID, PerformanceID, Price, Quantity, DateOnly) values ";
            for (int i = 0; i < records.Count; i++)
            {
                string n = records[i].Price.ToString();
                n = n.Replace(',', '.');
                _sql += "(" + records[i].CustomerID+ ", " + records[i].PerformanceID + ", " + n + ", " + records[i].Quantity + ", " + "'" + records[i].Date + "'" + ")";
                if (i == records.Count - 1)
                {
                    _sql += ";";
                }
                else
                {
                    _sql += ",";
                }
            }
            sqlConnection(_sql);
        }
    }
}
