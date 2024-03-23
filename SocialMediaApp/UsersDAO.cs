using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class UsersDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=social_media_database;";

        public List<Users> getAllUsers()
        {
            List<Users> returnThese = new List<Users>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT user_id, username, profile_photo_url, bio, email, created_at FROM Users", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users users = new Users
                    {
                        user_id = reader.GetInt32(0),
                        username = reader.GetString(1),
                        profilePicURL = reader.GetString(2),
                        bio = reader.GetString(3),
                        email = reader.GetString(4),
                        created_at = reader.GetDateTime(5),
                    };

                    returnThese.Add(users);

                }
            }
                connection.Close();

                return returnThese;
        }
        
        public List<Users> searchUsers(string searchTerm)
        {
            List<Users> returnThese = new List<Users>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchwildphrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT user_id, username, profile_photo_url, bio, email, created_at FROM Users WHERE username LIKE @search";
            command.Parameters.AddWithValue("@search", searchwildphrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users users = new Users
                    {
                        user_id = reader.GetInt32(0),
                        username = reader.GetString(1),
                        profilePicURL = reader.GetString(2),
                        bio = reader.GetString(3),
                        email = reader.GetString(4),
                        created_at = reader.GetDateTime(5),
                    };

                    returnThese.Add(users);

                }
            }
                connection.Close();

                return returnThese;
        }

        internal int addOneItem(Users user)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command1 = new MySqlCommand("INSERT INTO Users (username, email, bio, profile_photo_url, password) VALUES (@username, @email, @bio, @profilePicURL, @password)", connection);
            MySqlCommand command2 = new MySqlCommand("INSERT INTO Users (username, email, bio, password) VALUES (@username, @email, @bio, @password)", connection);

            if(user.username == String.Empty || user.email == String.Empty || user.password == String.Empty) 
            {
                connection.Close();
                return -1;
            }

            int result = 0;
            try
            {
                if (user.profilePicURL == String.Empty)
                {
                    command2.Parameters.AddWithValue("@username", user.username);
                    command2.Parameters.AddWithValue("@email", user.email);
                    command2.Parameters.AddWithValue("@bio", user.bio);
                    command2.Parameters.AddWithValue("@password", user.password);

                    result = command2.ExecuteNonQuery();
                }
                else
                {
                    command1.Parameters.AddWithValue("@username", user.username);
                    command1.Parameters.AddWithValue("@email", user.email);
                    command1.Parameters.AddWithValue("@bio", user.bio);
                    command1.Parameters.AddWithValue("@profilePicURL", user.profilePicURL);
                    command1.Parameters.AddWithValue("@password", user.password);

                    result = command1.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("A user with that username already exists.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        internal object getAllUsersForFollow(int user_id)
        {
            List<Users> returnThese = new List<Users>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT user_id FROM Users WHERE user_id <> @user_id", connection);
            command.Parameters.AddWithValue("@user_id", user_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users users = new Users
                    {
                        user_id = reader.GetInt32(0)
                    };

                    returnThese.Add(users);

                }
            }
            connection.Close();

            return returnThese;
        }

        internal int loginUser(Users user)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            int result = -1;

            if(user.email == String.Empty || user.password == String.Empty)
            {
                return 0;
            }

            MySqlCommand command = new MySqlCommand("SELECT user_id FROM USERS WHERE email = @email AND password = @password", connection);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@password", user.password);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result = reader.GetInt32(0);
                }
            }

            connection.Close();
            return result;
        }
    }
}
