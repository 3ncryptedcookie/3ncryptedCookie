using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptedCookie.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDraft { get; set; }
        public int UserId { get; set; }
    }
}
