using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDWpf
{
    public class Class1
    {
        SqliteConnection Connection;
        string connectionString = "URI=file:games.db";
        SqliteCommand Command; 

        public bool Open()
        {
            Connection = new SqliteConnection(connectionString);
            Connection.Open();

            Command = Connection.CreateCommand();
            Command.CommandText = "CREATE TABLE IF NOT EXIST score(pseudo VARCHAR(100), score INT)";
            Command.ExecuteNonQuery();


            Command.Dispose();

            Command = Connection.CreateCommand();
            Command.CommandText = "SELECT";
            SqliteDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {

                // récupération de la 2ème colonne
                reader.GetString(1);
            }


            reader.Close();
            Command.Dispose();
            Connection.Close();

            return true;
            

        }



           
    }
}
