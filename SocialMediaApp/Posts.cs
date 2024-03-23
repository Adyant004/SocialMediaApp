using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    internal class Posts
    {
        public int post_id { get; set; }
        public string photo_url { get; set; }
        public string caption { get; set; }
        public string location { get; set; }
        public DateTime created_at { get; set; }
    }
}