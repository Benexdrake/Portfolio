using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geldautomat_Console_SQL
{
    public class LoginDB
    {
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;
        string loginDB = @"Data Source = localhost; Port = 3306; Initial Catalog = Geldautomat; User Id = root; Password = 111111;";
        public Kunde kunde;
        public bool isloginOk;

        bool login(string sql)
        {
            try
            {
                con = new MySqlConnection(loginDB);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                Console.ReadKey();
                return false;
                
            }

        }

        public void readSql(string sql)
        {
            isloginOk = login(sql);
            if(isloginOk == true)
            {
                kunde = new Kunde();
                reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        kunde.kID = reader.GetInt32(0);
                        kunde.kVorName = reader.GetString(1);
                        kunde.kNachName = reader.GetString(2);
                        kunde.kIban = reader.GetString(3);
                        kunde.kPassword = reader.GetString(4);
                        kunde.kontoStand = reader.GetInt32(6);
                        kunde.available = reader.GetBoolean(7);
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Iban oder Passwort falsch!");
            }


        }

        public void writeSql(string Sql)
        {
            login(Sql);
        }

    }
}
