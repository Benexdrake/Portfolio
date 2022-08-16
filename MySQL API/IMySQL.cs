using MySql.Data.MySqlClient;

namespace MySQL_API
{
    public interface IMySQL
    {
        public MySqlConnection Con { get;}
        public MySqlDataReader Reader { get;} 
        public MySqlCommand Cmd { get;}
        public string ErrorMessage { get;}
        public string Username { set; }
        public string Password { set; }
        public string Port { set; }
        public string DBName { set; }
        public string DataSource { set; }
        bool LoginDB();
        MySqlDataReader GetReader(string sql);
        List<string> Read(string sql);
        void Write(string sql);
        void SetWrite(string sql, List<string> values);
    }
}
