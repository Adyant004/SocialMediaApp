using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class Users
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string bio { get; set; }
        public DateTime created_at { get; set; }
        public string profilePicURL { get; set; }
        public string password { get; set; }
    }
}
