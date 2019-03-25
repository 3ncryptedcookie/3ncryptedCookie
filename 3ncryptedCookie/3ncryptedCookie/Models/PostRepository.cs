using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptedCookie.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext _blogDbContext;

        public PostRepository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;            
        }

        public void Add(Post post)
        {
            _blogDbContext.Posts.Add(post);
            _blogDbContext.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return _blogDbContext.Posts;
        }

        public Post GetById(int id)
        {
            return _blogDbContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            Post postToDelete = GetById(id);
            _blogDbContext.Posts.Remove(postToDelete);
            _blogDbContext.SaveChanges();
        }
    }
}
