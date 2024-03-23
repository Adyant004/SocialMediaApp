using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaApp
{
    public partial class Form3 : Form
    {
        private int user_id;
        BindingSource userBindingSource = new BindingSource();
        BindingSource postBindingSource = new BindingSource();
        BindingSource followerBindingSource = new BindingSource();
        BindingSource followeeBindingSource = new BindingSource();
        public Form3(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show Bookmarks
            PostsDAO postDAO = new PostsDAO();
            postBindingSource.DataSource = postDAO.getBookmarks(user_id);
            dataGridView1.DataSource = postBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Go back
            this.Hide();

            Form2 form2 = new Form2(user_id);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Remove Bookmark
            int rowClicked = -1;
            try
            {
                rowClicked = dataGridView1.CurrentRow.Index;
            }
            catch
            {
                MessageBox.Show("Please select a cell!");
            }
            int postId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            PostsDAO postDAO = new PostsDAO();
            int result = postDAO.removeBookmark(postId, user_id);

            if (result != -1)
            {
                MessageBox.Show("Bookmark removed!");
            }
            else
            {
                MessageBox.Show("Please select a post!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Show Follows
            FollowDAO followDAO = new FollowDAO();
            UsersDAO usersDAO = new UsersDAO();
            followerBindingSource.DataSource = followDAO.getFollowers(user_id);
            dataGridView2.DataSource = followerBindingSource;

            followeeBindingSource.DataSource = followDAO.getFollowing(user_id);
            dataGridView3.DataSource = followeeBindingSource;

            userBindingSource.DataSource = usersDAO.getAllUsersForFollow(user_id);
            dataGridView1.DataSource = userBindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Follow
            FollowDAO followDAO = new FollowDAO();
            int rowClicked = dataGridView1.CurrentRow.Index;
            int userId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            int result = followDAO.followUser(user_id, userId);

            if(result != -1)
            {
                MessageBox.Show("You followed " + userId);
            }
            else
            {
                MessageBox.Show("Already followed!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Unfollow
            FollowDAO followDAO = new FollowDAO();
            int rowClicked = dataGridView1.CurrentRow.Index;
            int userId = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            int result = followDAO.unfollowUser(user_id, userId);

            if (result != -1)
            {
                MessageBox.Show("You unfollowed " + userId);
            }
            else
            {
                MessageBox.Show("Already unfollowed!");
            }
        }
    }
}
