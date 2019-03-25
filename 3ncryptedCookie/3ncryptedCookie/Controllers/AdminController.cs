using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncryptedCookie.Models;
using Microsoft.AspNetCore.Mvc;

namespace _3ncryptedCookie.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<Post> postList = new List<Post>
            {
                new Post{ Id = 1, Title = "Title1", Body = "Description", DateCreated = new System.DateTime(2015, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2015, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2015, 3, 10, 2, 15, 10)},
                new Post{ Id = 1, Title = "Title2", Body = "Description", DateCreated = new System.DateTime(2016, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2016, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2016, 3, 10, 2, 15, 10)},
                new Post{ Id = 1, Title = "Title3", Body = "Description", DateCreated = new System.DateTime(2017, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2017, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2017, 3, 10, 2, 15, 10)},
            };

            return View(postList);
        }


        //Link to create a new post
        public ActionResult Create()
        {
            return View();
        }
    }
}