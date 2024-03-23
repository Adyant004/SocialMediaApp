using System.CodeDom;
using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp
{
    public partial class Form1 : Form
    {
        BindingSource usersBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersDAO usersDAO = new UsersDAO();

            usersBindingSource.DataSource = usersDAO.getAllUsers();

            dataGridView1.DataSource = usersBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;
            // MessageBox.Show("You clicked " + rowClicked);

            string imageURL = dataGridView.Rows[rowClicked].Cells[5].Value.ToString();
            //MessageBox.Show("URL = " + imageURL);

            try
            {
                pictureBox1.Load(imageURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find the photo url!");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            UsersDAO usersDAO = new UsersDAO();

            usersBindingSource.DataSource = usersDAO.searchUsers(textBox1.Text);

            dataGridView1.DataSource = usersBindingSource;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                username = txt_username.Text,
                email = txt_email.Text,
                bio = txt_bio.Text,
                profilePicURL = txt_url.Text,
                password = txt_password.Text
            };

            UsersDAO userDAO = new UsersDAO();
            int result = userDAO.addOneItem(user);

            if (result == -1)
            {
                MessageBox.Show("Username, Email, Password cannot be left blank");
            }
            else
            {
                MessageBox.Show(result + " new user inserted");
            }


            txt_username.Text = "";
            txt_email.Text = "";
            txt_bio.Text = "";
            txt_url.Text = "";
            txt_password.Text = "";
        }

        private void txt_bio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                email = txt_email_login.Text,
                password = txt_password_login.Text 
            };

            UsersDAO userDAO = new UsersDAO();
            int result = userDAO.loginUser(user);

            txt_email_login.Text = "";
            txt_password_login.Text = "";

            if(result == -1)
            {
                MessageBox.Show("User does not exist!");
            } else if(result == 0)
            {
                MessageBox.Show("Email and password cannot be left blank");
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2(result);
                form2.Show();
            }
        }
    }
}
