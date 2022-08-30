using MySql.Data.MySqlClient;
using System.Data;

namespace MySQL_API
{
    public class MysqlDB : IMySQL
    {
        public MySqlConnection Con { get; private set; }
        public MySqlDataReader Reader { get; private set; }
        public MySqlCommand Cmd { get; private set; }
        public string ErrorMessage { get; private set; }
        public string Username { private get; set; }
        public string Password { private get; set; }
        public string Port { private get; set; }
        public string DBName { private get; set; }
        public string DataSource { private get; set; }

        public MysqlDB(string username, string password, string port, string dBName, string dataSource)
        {
            Username = username;
            Password = password;
            Port = port;
            DBName = dBName;
            DataSource = dataSource;
        }

        #region Login into Database
        public bool LoginDB()
        {
            try
            {
                string connection = (@$"Data Source = {DataSource}; Port = {Port} ; 
                                        Initial Catalog = {DBName}; User Id = {Username}; Password = {Password};");
                Con = new MySqlConnection(connection);
                Con.Open();
                return true;
            }
            catch (Exception e)
            {
                ErrorMessage = e.ToString();
                if(Con.State != ConnectionState.Closed)
                Con.Close();
                return false;
            }
        }
        #endregion

        #region Read from Database with String List Return

        // Read all Columns from Database and saved it in string as List, later can be split by ;
        public List<string> Read(string sql)
        {
            List<string> list = new();

            if (LoginDB())
            {
                Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;
                Reader = Cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        string column = string.Empty;
                        for (int i = 0; i < Reader.FieldCount; i++)
                        {
                            column += Reader.GetString(i);
                            if (i == Reader.FieldCount - 1)
                                break;
                            column += ";";
                        }
                        list.Add(column);
                    }
                }
                Con.Close();
            }

            return list;
        }

        #endregion

        #region Read from Database with MysqlDataReader return

        public MySqlDataReader GetReader(string sql)
        {
            if (LoginDB())
            {
                Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;    
                Reader = Cmd.ExecuteReader();
                Con.Close();
                return Reader;
            }
            return null;
        }

        #endregion

        #region Write Data into DB

        // need sql Statement insert into Table values (data, data, data);
        public void Write(string sql)
        {
            if (LoginDB())
            {
                Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
        }

        #endregion

        #region Send Data to Database table for Tablename and Values for (data, "data", data);
        public void SetWrite(string table, List<string> values)
        {
            string query = $"insert into {table} values ";
            for (int i = 0; i < values.Count; i++)
            {
                query += values[i];

                if (i == values.Count - 1)
                {
                    query += ";";
                    break;
                }
                query += ",";
            }

            if (LoginDB())
            {
                Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = query;
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
        }
        #endregion
    }
}
