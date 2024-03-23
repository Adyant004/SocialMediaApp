using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class SqlDatabase
    {
        /*
         * #DROP DATABASE Social_Media_Database;
CREATE DATABASE IF NOT EXISTS Social_Media_Database;
USE Social_Media_Database;

CREATE TABLE IF NOT EXISTS Users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(255) UNIQUE NOT NULL,
    profile_photo_url VARCHAR(255) DEFAULT 'https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Question_opening-closing.svg/117px-Question_opening-closing.svg.png',
    bio VARCHAR(255),
    email VARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT NOW(),
    password VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS Posts(
	post_id INT AUTO_INCREMENT PRIMARY KEY,
    photo_url TEXT NOT NULL,
    user_id INT NOT NULL,
    caption VARCHAR(200), 
    location VARCHAR(50) ,
    created_at DATETIME DEFAULT NOW(),
    CONSTRAINT fk_user_id FOREIGN KEY(user_id) REFERENCES Users(user_id) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Comments(
    comment_id INT AUTO_INCREMENT PRIMARY KEY,
    comment_text VARCHAR(255) NOT NULL,
    post_id INT NOT NULL,
    user_id INT NOT NULL,
    created_at DATETIME DEFAULT NOW(),
    CONSTRAINT fk_post_comment_id FOREIGN KEY(post_id) REFERENCES Posts(post_id) ON DELETE CASCADE,
    CONSTRAINT fk_user_comment_id FOREIGN KEY(user_id) REFERENCES Users(user_id) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Post_likes(
    user_id INT NOT NULL,
    post_id INT NOT NULL,
    created_at DATETIME DEFAULT NOW(),
    CONSTRAINT fk_user_plikes_id FOREIGN KEY(user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    CONSTRAINT fk_post_plikes_id FOREIGN KEY(post_id) REFERENCES Posts(post_id) ON DELETE CASCADE,
    PRIMARY KEY(user_id, post_id)
);

CREATE TABLE IF NOT EXISTS Follows(
    follower_id INT NOT NULL,
    followee_id INT NOT NULL,
    created_at DATETIME DEFAULT NOW(),
    CONSTRAINT fk_follower_id FOREIGN KEY(follower_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    CONSTRAINT fk_followee_id FOREIGN KEY(followee_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    PRIMARY KEY(follower_id, followee_id)
);

CREATE TABLE IF NOT EXISTS Bookmarks (
  post_id INT NOT NULL,
  user_id INT NOT NULL,
  created_at DATETIME DEFAULT NOW(),
  CONSTRAINT fk_book_post_id FOREIGN KEY(post_id) REFERENCES Posts(post_id) ON DELETE CASCADE,
  CONSTRAINT fk_book_user_id FOREIGN KEY(user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
  PRIMARY KEY(user_id, post_id)
);
         * 
         */
    }
}
