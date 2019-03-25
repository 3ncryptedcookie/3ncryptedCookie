using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptedCookie.Models
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Remove(int id);
        Post GetById(int id);
        IEnumerable<Post> GetAll();
    }
}
