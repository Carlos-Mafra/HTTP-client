using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPclient.Models
{
    internal class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
    }
}
