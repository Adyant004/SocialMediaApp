namespace SocialMediaApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            txt_location = new TextBox();
            label4 = new Label();
            txt_caption = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txt_photo_url = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button8 = new Button();
            button9 = new Button();
            groupBox2 = new GroupBox();
            button12 = new Button();
            txt_comment = new TextBox();
            label2 = new Label();
            button10 = new Button();
            button11 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(956, 630);
            button1.Name = "button1";
            button1.Size = new Size(138, 43);
            button1.TabIndex = 0;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txt_location);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_caption);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_photo_url);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Post";
            groupBox1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(193, 164);
            button2.Name = "button2";
            button2.Size = new Size(130, 42);
            button2.TabIndex = 10;
            button2.Text = "Post";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // txt_location
            // 
            txt_location.Location = new Point(152, 113);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(179, 31);
            txt_location.TabIndex = 9;
            txt_location.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 113);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 8;
            label4.Text = "location";
            label4.UseWaitCursor = true;
            // 
            // txt_caption
            // 
            txt_caption.Location = new Point(152, 75);
            txt_caption.Name = "txt_caption";
            txt_caption.Size = new Size(179, 31);
            txt_caption.TabIndex = 7;
            txt_caption.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 75);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "caption";
            label3.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 3;
            label1.Text = "Photo URL";
            label1.UseWaitCursor = true;
            // 
            // txt_photo_url
            // 
            txt_photo_url.Location = new Point(152, 30);
            txt_photo_url.Name = "txt_photo_url";
            txt_photo_url.Size = new Size(179, 31);
            txt_photo_url.TabIndex = 2;
            txt_photo_url.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(730, 228);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(635, 246);
            button3.Name = "button3";
            button3.Size = new Size(149, 42);
            button3.TabIndex = 3;
            button3.Text = "Bookmark Post";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(790, 246);
            button4.Name = "button4";
            button4.Size = new Size(149, 42);
            button4.TabIndex = 4;
            button4.Text = "My Posts";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(945, 246);
            button5.Name = "button5";
            button5.Size = new Size(149, 42);
            button5.TabIndex = 5;
            button5.Text = "Posts";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(480, 246);
            button6.Name = "button6";
            button6.Size = new Size(149, 42);
            button6.TabIndex = 7;
            button6.Text = "Profile";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(790, 631);
            button7.Name = "button7";
            button7.Size = new Size(149, 42);
            button7.TabIndex = 8;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(364, 294);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(730, 98);
            dataGridView2.TabIndex = 9;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(364, 398);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(420, 98);
            dataGridView3.TabIndex = 10;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button8
            // 
            button8.Location = new Point(12, 625);
            button8.Name = "button8";
            button8.Size = new Size(149, 42);
            button8.TabIndex = 11;
            button8.Text = "Like";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(790, 520);
            button9.Name = "button9";
            button9.Size = new Size(149, 42);
            button9.TabIndex = 12;
            button9.Text = "View Comments";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(txt_comment);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(364, 508);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 165);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add a comment";
            // 
            // button12
            // 
            button12.Location = new Point(265, 117);
            button12.Name = "button12";
            button12.Size = new Size(149, 42);
            button12.TabIndex = 16;
            button12.Text = "Add Comment";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // txt_comment
            // 
            txt_comment.Location = new Point(116, 44);
            txt_comment.Multiline = true;
            txt_comment.Name = "txt_comment";
            txt_comment.Size = new Size(298, 52);
            txt_comment.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Comment";
            // 
            // button10
            // 
            button10.Location = new Point(200, 625);
            button10.Name = "button10";
            button10.Size = new Size(149, 42);
            button10.TabIndex = 14;
            button10.Text = "Unlike";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(945, 520);
            button11.Name = "button11";
            button11.Size = new Size(149, 42);
            button11.TabIndex = 15;
            button11.Text = "View Likes";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 685);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(groupBox2);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt_photo_url;
        private TextBox txt_caption;
        private Label label3;
        private Button button2;
        private TextBox txt_location;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button7;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button8;
        private Button button9;
        private GroupBox groupBox2;
        private TextBox txt_comment;
        private Label label2;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}