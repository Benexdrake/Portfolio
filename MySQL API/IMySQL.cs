using MySql.Data.MySqlClient;

namespace MySQL_API
{
    public interface IMySQL
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
        bool LoginDB(string sql);
    }
}
