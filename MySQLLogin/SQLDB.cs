using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLLogin
{
    public class SQLDB : IMySql
    {
        public bool isLoginOk;
        private string error;
        public string Error { get => error; set => error = value; }

        string dataSource, port, db, user, pw;

        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public SQLDB(string _dataSource, string _port, string _db, string _user, string _pw)
        {
            dataSource = _dataSource;
            port = _port;
            db = _db;
            user = _user;
            pw = _pw;
        }

        public bool LoginDB(string sql)
        {
            try
            {
                string connection = (@$"Data Source = {dataSource}; Port = {port} ; Initial Catalog = {db}; User Id = {user}; Password = {pw};");

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
                error = e.ToString();
                con.Close();
                return false;
            }
        }

        public List<Actors> GetActors(string sql)
        {
            isLoginOk = LoginDB(sql);

            if (isLoginOk)
            {
                List<Actors> actors = new List<Actors>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        actors.Add(
                        new Actors()
                        {
                            ID = reader.GetInt32("actor_id"),
                            Firstname = reader.GetString("first_name"),
                            Lastname = reader.GetString("last_name")
                        });
                    }
                }
                con.Close();
                return actors;
            }
            con.Close();
            return null;
        }
    }
}
