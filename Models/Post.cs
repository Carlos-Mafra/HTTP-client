using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPclient.Models
{
    internal class Post
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
