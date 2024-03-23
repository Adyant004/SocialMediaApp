using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaApp
{
    public partial class Form2 : Form
    {
        private int user_id;
        BindingSource postBindingSource = new BindingSource();
        BindingSource likeBindingSource = new BindingSource();
        BindingSource commentBindingSource = new BindingSource();
        public Form2(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Log Out
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add a post
            Posts post = new Posts
            {
                photo_url = txt_photo_url.Text,
                caption = txt_caption.Text,
                location = txt_location.Text
            };

            PostsDAO postDAO = new PostsDAO();
            int result = postDAO.addOnePost(post, user_id);

            MessageBox.Show(result + " new post inserted");

            txt_photo_url.Text = "";
            txt_caption.Text = "";
            txt_location.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //My Posts
            PostsDAO postDAO = new PostsDAO();

            postBindingSource.DataSource = postDAO.getMyPosts(user_id);

            dataGridView1.DataSource = postBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Posts Grid
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            string imageURL = dataGridView.Rows[rowClicked].Cells[1].Value.ToString();

            try
            {
                // Create a new WebClient instance and set the User-Agent header
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36");

                // Download the image and load it into the PictureBox
                byte[] imageData = webClient.DownloadData(imageURL);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Posts
            PostsDAO postDAO = new PostsDAO();

            postBindingSource.DataSource = postDAO.getOtherPosts(user_id);

            dataGridView1.DataSource = postBindingSource;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Delete Post
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            PostsDAO postDAO = new PostsDAO();
            int result = postDAO.deletePost(postId, user_id);

            if (result != -1)
            {
                MessageBox.Show(result + " row deleted!");
            }
            else
            {
                MessageBox.Show("You cannot delete other's post!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bookmark post
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            PostsDAO postDAO = new PostsDAO();
            int result = postDAO.bookmarkPost(postId, user_id);
            if (result != -1)
            {
                MessageBox.Show("Added to Bookmarks!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Like Button
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            PostsDAO postDAO = new PostsDAO();
            int result = postDAO.likePost(postId, user_id);

            if (result != -1)
            {
                MessageBox.Show(result + " like added!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Dislike button
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            PostsDAO postDAO = new PostsDAO();
            int result = postDAO.unlikePost(postId, user_id);

            if (result != -1)
            {
                MessageBox.Show(result + " like removed!");
            }
            else
            {
                MessageBox.Show("Already unliked!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //View Likes
            PostsDAO postDAO = new PostsDAO();
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            likeBindingSource.DataSource = postDAO.viewAllLikes(postId);

            dataGridView3.DataSource = likeBindingSource;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //View Comments
            CommentsDAO commentDAO = new CommentsDAO();
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            commentBindingSource.DataSource = commentDAO.getAllComments(postId);
            dataGridView2.DataSource = commentBindingSource;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Add comment
            CommentsDAO commentDAO = new CommentsDAO();
            int rowClicked = dataGridView1.CurrentRow.Index;
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            Comments comment = new Comments
            {
                comment_text = txt_comment.Text
            };

            int result = commentDAO.addComment(comment, postId, user_id);

            txt_comment.Text = "";

            if (result == -1)
            {
                MessageBox.Show("Comment cannot be blank!");
            }
            else
            {
                MessageBox.Show(result + " comment added!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Profile
            this.Hide();

            Form3 form3 = new Form3(user_id);
            form3.Show();
        }
    }
}
