using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class Comments
    {
        public int comment_id { get; set; }
        public string comment_text { get; set; }
        public int user_id { get; set; }
        public DateTime created_at { get; set; }
    }
}
