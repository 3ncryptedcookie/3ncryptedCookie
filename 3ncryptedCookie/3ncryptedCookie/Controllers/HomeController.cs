using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _3ncryptedCookie.Models;
using EncryptedCookie.Models;

namespace _3ncryptedCookie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string searchTerm = null)
        {
            List<Post> postList1 = new List<Post>
            {
                new Post{ Id = 1, Title = "Title1", Body = "Description", DateCreated = new System.DateTime(2015, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2015, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2015, 3, 10, 2, 15, 10)},
                new Post{ Id = 2, Title = "Title2", Body = "Description", DateCreated = new System.DateTime(2016, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2016, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2016, 3, 10, 2, 15, 10)},
                new Post{ Id = 3, Title = "Title3", Body = "Description", DateCreated = new System.DateTime(2017, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2017, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2017, 3, 10, 2, 15, 10)},
            };

            List<Post> model = postList1
                                .OrderByDescending(r => r.DateCreated)
                                .Where(r => searchTerm == null || r.Title.StartsWith(searchTerm))
                                .ToList();

            return View(model);
         }


      }
}
