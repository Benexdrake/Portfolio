using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notizen_Forms
{
    internal class SqlDB
    {
        public bool isLoginOk;

        public List<Protocol> protocols = new List<Protocol>();

        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

       public bool SqlConnection(string sql)
        {
            try
            {
                string connection = @$"Data Source = localhost; Port = 3306; Initial Catalog = {Save.mode};User Id = {Save.username}; Password = {Save.password};";

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
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void ReadSql(string sql, int variant)
        {
            isLoginOk = SqlConnection(sql);

            protocols.Clear();
            if(isLoginOk)
            {
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    switch(variant)
                    {
                        case 0: // Select * From Professor
                            while(reader.Read())
                            {
                                protocols.Add(new Protocol
                                {
                                    professor = reader.GetInt32(0),
                                    professorName = reader.GetString(1)
                                }) ;
                            }
                            break;

                        case 1: // Select * From Course
                            while (reader.Read())
                            {
                                protocols.Add(new Protocol
                                {
                                    course = reader.GetInt32(0),
                                    courseName = reader.GetString(1)
                                });
                            }
                            break;

                        case 2: // Select * from SeeNotes
                            while (reader.Read())
                            {
                                protocols.Add(new Protocol
                                {
                                    id = reader.GetInt32(0),
                                    note = reader.GetString(1),
                                    text = reader.GetString(2),
                                    dateTime = reader.GetDateTime(3),
                                    day = reader.GetString(4),
                                    courseName = reader.GetString(5),
                                    professorName=reader.GetString(6)
                                }) ;
                            }
                            break;
                    }
                }
                con.Close();
            }

            
        }
    }
}
