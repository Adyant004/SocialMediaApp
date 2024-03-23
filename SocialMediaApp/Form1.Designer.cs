namespace SocialMediaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txt_password = new TextBox();
            label5 = new Label();
            button3 = new Button();
            txt_url = new TextBox();
            txt_bio = new TextBox();
            txt_email = new TextBox();
            txt_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            txt_password_login = new TextBox();
            txt_email_login = new TextBox();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(291, 362);
            button1.Name = "button1";
            button1.Size = new Size(176, 31);
            button1.TabIndex = 0;
            button1.Text = "Load All Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(876, 212);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(1011, 362);
            button2.Name = "button2";
            button2.Size = new Size(156, 31);
            button2.TabIndex = 2;
            button2.Text = "Search User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(704, 362);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search for a user";
            textBox1.Size = new Size(301, 31);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(12, 362);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_url);
            groupBox1.Controls.Add(txt_bio);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 318);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add User";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(189, 214);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(246, 31);
            txt_password.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 220);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // button3
            // 
            button3.Location = new Point(327, 264);
            button3.Name = "button3";
            button3.Size = new Size(108, 37);
            button3.TabIndex = 8;
            button3.Text = "Add User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(189, 170);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(246, 31);
            txt_url.TabIndex = 7;
            // 
            // txt_bio
            // 
            txt_bio.Location = new Point(189, 127);
            txt_bio.Name = "txt_bio";
            txt_bio.Size = new Size(246, 31);
            txt_bio.TabIndex = 6;
            txt_bio.TextChanged += txt_bio_TextChanged;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(189, 85);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(246, 31);
            txt_email.TabIndex = 5;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(189, 44);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(246, 31);
            txt_username.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 176);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Profile Pic URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 133);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 2;
            label3.Text = "Bio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 50);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(txt_password_login);
            groupBox2.Controls.Add(txt_email_login);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(760, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 227);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // button4
            // 
            button4.Location = new Point(242, 167);
            button4.Name = "button4";
            button4.Size = new Size(141, 37);
            button4.TabIndex = 11;
            button4.Text = "Login User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txt_password_login
            // 
            txt_password_login.Location = new Point(137, 91);
            txt_password_login.Name = "txt_password_login";
            txt_password_login.Size = new Size(246, 31);
            txt_password_login.TabIndex = 12;
            // 
            // txt_email_login
            // 
            txt_email_login.Location = new Point(137, 43);
            txt_email_login.Name = "txt_email_login";
            txt_email_login.Size = new Size(246, 31);
            txt_email_login.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 91);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 46);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1189, 672);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button button3;
        private TextBox txt_url;
        private TextBox txt_bio;
        private TextBox txt_email;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label5;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox txt_password_login;
        private TextBox txt_email_login;
        private Label label7;
        private Label label6;
    }
}
