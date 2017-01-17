using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDWpf
{
    public static class UserManager
    {

        static SQLiteConnection Connection;
        static string connectionString = "URI=file:scoringBoard.db";
        static SQLiteCommand Command;

        public static void Open()
        {
            Connection = new SQLiteConnection(connectionString);
            Connection.Open();

            Command = Connection.CreateCommand();
            Command.CommandText = "CREATE TABLE IF NOT EXISTS score(pseudo VARCHAR(100), score INT)";
            Command.ExecuteNonQuery();

            Command.Dispose();
        }

        public static bool Add(string pseudo, int score)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "INSERT INTO score(pseudo, score) VALUES (\"" + pseudo + "\"," + score + ")";
            int insertLines = Command.ExecuteNonQuery();
            Command.Dispose();
            return insertLines > 0;
        }

        public static List<User> GetByScore()
        {
            List<User> scoringBoard = new List<User>();
            Command = Connection.CreateCommand();
            Command.CommandText = "SELECT pseudo, score FROM scoringBoard ORDER BY score DESC LIMIT 5";
            SQLiteDataReader reader = Command.ExecuteReader();
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

        public static List<User> GetAll()
        {
            List<User> allUsers = new List<User>();
            Command = Connection.CreateCommand();
            Command.CommandText = "SELECT pseudo, score FROM score";
            SQLiteDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    allUsers.Add(new User(reader.GetString(0), reader.GetInt32(1)));
                }
            }
            reader.Close();
            Command.Dispose();
            return allUsers;
        }

        public static bool CleanDB()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "DELETE FROM score";
            int insertLines = Command.ExecuteNonQuery();
            Command.Dispose();
            return insertLines > 0;
        }

    }
}
