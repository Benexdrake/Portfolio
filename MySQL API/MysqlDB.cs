using MySql.Data.MySqlClient;
using System.Data;

namespace MySQL_API
{
    public class MysqlDB : IMySQL
    {
        public MySqlConnection Con { get; set; }
        public MySqlDataReader Reader { get; set; }
        public MySqlCommand Cmd { get; set; }
        public string ErrorMessage { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string DBName { get; set; }
        public string DataSource { get; set; }

        public MysqlDB(string username, string password, string port, string dBName, string dataSource)
        {
            Username = username;
            Password = password;
            Port = port;
            DBName = dBName;
            DataSource = dataSource;
        }

        public bool LoginDB(string sql)
        {
            try
            {
                string connection = (@$"Data Source = {DataSource}; Port = {Port} ; Initial Catalog = {DBName}; User Id = {Username}; Password = {Password};");
                Con = new MySqlConnection(connection);
                Con.Open();
                Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
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
    }
}
