using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class CommentsDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=social_media_database;";

        internal int addComment(Comments comment,int postId, int user_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO Comments (comment_text,post_id,user_id) VALUES(@comment_text,@post_id,@user_id)", connection);
            command.Parameters.AddWithValue("@post_id", postId);
            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@comment_text", comment.comment_text);

            int result = -1;

            if(comment.comment_text == String.Empty)
            {
                return result;
            }

            try
            {
                result = command.ExecuteNonQuery();
            } catch
            {

            } finally
            {
                connection.Close();
            }

            return result;
        }

        internal object getAllComments(int postId)
        {
            List<Comments> comments = new List<Comments>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT comment_id,comment_text,user_id,created_at FROM Comments WHERE post_id = @post_id", connection);
            command.Parameters.AddWithValue("@post_id", postId);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Comments comment = new Comments
                    {
                        comment_id = reader.GetInt32(0),
                        comment_text = reader.GetString(1),
                        user_id = reader.GetInt32(2),
                        created_at = reader.GetDateTime(3)
                    };
                    comments.Add(comment);
                }
            }

            connection.Close();
            return comments;
        }
    }
}
