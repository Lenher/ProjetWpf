using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDWpf
{
    public class UserManager
    {
        public string pseudo;
        public int score;

        SqliteConnection Connection;
        string connectionString = "URI=file:scoringBoard.db";
        SqliteCommand Command;

        public void Open()
        {
            Connection = new SqliteConnection(connectionString);
            Connection.Open();

            Command = Connection.CreateCommand();
            Command.CommandText = "CREATE TABLE IF NOT EXIST score(pseudo VARCHAR(100), score INT)";
            Command.ExecuteNonQuery();

            Command.Dispose();
        }

        public bool add(string pseudo, int score)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "INSERT INTO score(pseudo, score) VALUE(" + pseudo + "," + score + ")";
            int insertLines = Command.ExecuteNonQuery();
            Command.Dispose();
            return insertLines > 0;
        }

        public List<User> getByScore()
        {
            List<User> scoringBoard = new List<User>();
            Command = Connection.CreateCommand();
            Command.CommandText = "SELECT pseudo, score FROM scoringBoard ORDER BY score DESC LIMIT 5";
            SqliteDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    scoringBoard.Add(new User(reader.GetString(0), reader.GetInt32(1)));
                }
            }

            reader.Close();
            Command.Dispose();

            return scoringBoard;
        }

    }
}
