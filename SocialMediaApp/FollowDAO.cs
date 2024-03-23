using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class FollowDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=social_media_database;";

        internal int followUser(int user_id, int userId)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO Follows (followee_id,follower_id) VALUES (@followee_id,@follower_id)", connection);
            command.Parameters.AddWithValue("@followee_id", userId);
            command.Parameters.AddWithValue("@follower_id", user_id);

            int result = -1;

            try
            {
                result = command.ExecuteNonQuery();
            } catch
            {
                
            }
            return result;

        }

        internal object getFollowers(int user_id)
        {
            List<Follower> returnThese = new List<Follower>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT follower_id,created_at FROM Follows WHERE followee_id = @user_id", connection);
            command.Parameters.AddWithValue("@user_id", user_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Follower follower = new Follower
                    {
                        follower_id = reader.GetInt32(0),
                        created_at = reader.GetDateTime(1)
                    };

                    returnThese.Add(follower);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal object getFollowing(int user_id)
        {
            List<Following> returnThese = new List<Following>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT followee_id,created_at FROM Follows WHERE follower_id = @user_id", connection);
            command.Parameters.AddWithValue("@user_id", user_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Following following = new Following
                    {
                        followee_id = reader.GetInt32(0),
                        created_at = reader.GetDateTime(1)
                    };

                    returnThese.Add(following);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal int unfollowUser(int user_id, int userId)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM Follows WHERE followee_id = @followee_id AND follower_id = @follower_id", connection);
            command.Parameters.AddWithValue("@followee_id", userId);
            command.Parameters.AddWithValue("@follower_id", user_id);

            int result = -1;

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
