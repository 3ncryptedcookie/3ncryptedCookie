using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EncryptedCookie.Models;
using Microsoft.AspNetCore.Mvc;

namespace _3ncryptedCookie.Controllers
{
    public class AdminController : Controller
    {
        List<Post> postList = new List<Post>
            {
                new Post{ Id = 1, Title = "Title1", Body = "Description", DateCreated = new System.DateTime(2015, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2015, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2015, 3, 10, 2, 15, 10)},
                new Post{ Id = 2, Title = "Title2", Body = "Description", DateCreated = new System.DateTime(2016, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2016, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2016, 3, 10, 2, 15, 10)},
                new Post{ Id = 3, Title = "Title3", Body = "Description", DateCreated = new System.DateTime(2017, 3, 10, 2, 15, 10), DateModified = new System.DateTime(2017, 3, 10, 2, 15, 10), DatePublished = new System.DateTime(2017, 3, 10, 2, 15, 10)},
            };

        public IActionResult Index()
        {
            return View(postList);
        }

        //public IActionResult Index()
        //{

        //    return RedirectToAction("Login", "Account");
        //}


        //GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Post post)
        {
            if(ModelState.IsValid)
            {
                postList.Add(post);
            }

            return View(post);
        }

        // GET: Admin/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //Post post = postList.FindAll(id);
        //    if (post == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(post);
        //}

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Post restaurant)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(restaurant).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        //Link to create a new post
        public ActionResult Delete()
        {
            return View();
        }

        //Link to create a new post
        public ActionResult View(int? id)
        {
            //Post post = postList.Find(id);
            return View();
        }
    }
}