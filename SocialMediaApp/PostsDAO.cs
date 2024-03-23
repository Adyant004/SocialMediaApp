using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class PostsDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=social_media_database;";

        internal int addOnePost(Posts post, int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO Posts (photo_url, user_id, caption,location) VALUES (@photo_url,@user_id, @caption,@location)", connection);

            int result = -1;

            try
            {
                command.Parameters.AddWithValue("@photo_url", post.photo_url);
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@caption", post.caption);
                command.Parameters.AddWithValue("@location", post.location);

                result = command.ExecuteNonQuery();
            } catch (MySqlException ex)
            {
                if(ex.Number == 1062)
                {
                    MessageBox.Show("A post like this already exists!");
                }
                else
                {
                    MessageBox.Show("An error has occured " + ex.Message);
                }
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        internal int bookmarkPost(int postId, int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO Bookmarks (post_id, user_id) VALUES (@postId,@user_id)", connection);
            command.Parameters.AddWithValue("@postId", postId);
            command.Parameters.AddWithValue("@user_id", user_id);

            int result = -1;
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Already exists!");
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        internal int deletePost(int postId,int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM Posts WHERE post_id = @postId AND user_id = @user_id", connection);
            command.Parameters.AddWithValue("@postId", postId);
            command.Parameters.AddWithValue("@user_id", user_id);

            int result = -1;
            try
            {
                result = command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("An error has occured : " + ex.Message);
            } finally
            {
                connection.Close();
            }

            return result;
        }

        internal object getBookmarks(int user_id)
        {
            List<Bookmark> returnThese = new List<Bookmark>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT post_id,created_at FROM Bookmarks WHERE user_id = @user_id", connection);
            command.Parameters.AddWithValue("@user_id", user_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Bookmark bookmark = new Bookmark
                    {
                        post_id = reader.GetInt32(0),
                        created_at = reader.GetDateTime(1)
                    };

                    returnThese.Add(bookmark);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal object getMyPosts(int user_id)
        {
            List<Posts> returnThese = new List<Posts>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT post_id,photo_url,caption,location,created_at FROM Posts WHERE user_id = @user_id", connection);

            command.Parameters.AddWithValue("@user_id", user_id);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Posts post = new Posts
                    {
                        post_id = reader.GetInt32(0),
                        photo_url = reader.GetString(1),
                        caption = reader.GetString(2),
                        location = reader.GetString(3),
                        created_at = reader.GetDateTime(4)
                    };

                    returnThese.Add(post);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal object getOtherPosts(int user_id)
        {
            List<Posts> returnThese = new List<Posts>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT post_id,photo_url,caption,location,created_at FROM Posts WHERE user_id <> @user_id", connection);

            command.Parameters.AddWithValue("@user_id", user_id);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Posts post = new Posts
                    {
                        post_id = reader.GetInt32(0),
                        photo_url = reader.GetString(1),
                        caption = reader.GetString(2),
                        location = reader.GetString(3),
                        created_at = reader.GetDateTime(4)
                    };

                    returnThese.Add(post);
                }
            }

            connection.Close();
            return returnThese;
        }

        internal int likePost(int post_id, int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO Post_likes (user_id,post_id) VALUES (@user_id,@postId)", connection);

            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@postId", post_id);

            int result = -1;

            try
            {
                result = command.ExecuteNonQuery();
            } catch
            {
                MessageBox.Show("Already liked!");
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        internal int removeBookmark(int postId,int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM Bookmarks WHERE post_id = @postId AND user_id = @user_id", connection);

            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@postId", postId);

            int result = -1;

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Already removed!");
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        internal int unlikePost(int postId, int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM Post_likes WHERE post_id = @postId AND user_id = @user_id", connection);

            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@postId", postId);

            int result = -1;

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Already unliked!");
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        internal object viewAllLikes(int postId)
        {
            List<Post_likes> returnThese = new List<Post_likes>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT user_id,created_at FROM Post_likes WHERE post_id = @postId", connection);
            command.Parameters.AddWithValue("@postId", postId);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Post_likes postLikes = new Post_likes
                    {
                        user_id = reader.GetInt32(0),
                        created_at = reader.GetDateTime(1)
                    };
                    returnThese.Add(postLikes);
                }
            }

            connection.Close();
            return returnThese;
        }
    }
}
