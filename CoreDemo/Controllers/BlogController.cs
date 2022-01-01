using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var userMail = User.Identity.Name;
            Context c = new Context();
            var wID = c.Writers.Where(x => x.writerMail == userMail).Select(y => y.writerID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterManager(wID);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            ViewBag.cv = cm.GetCategoryList();

            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            var userMail = User.Identity.Name;
            var wID = c.Writers.Where(x => x.writerMail == userMail).Select(y => y.writerID).FirstOrDefault();

            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);

            if (results.IsValid)
            {
                p.blogStatus = true;
                p.blogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.writerID = wID;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = bm.TGetById(id);
            bm.TDelete(blogValue);

            return RedirectToAction("BlogListByWriter", "Blog");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            ViewBag.cv = cm.GetCategoryList();
            var blogValue = bm.TGetById(id);
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {

            var userMail = User.Identity.Name;            
            var wID = c.Writers.Where(x => x.writerMail == userMail).Select(y => y.writerID).FirstOrDefault();

            p.writerID = wID;
            p.blogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.blogStatus = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
