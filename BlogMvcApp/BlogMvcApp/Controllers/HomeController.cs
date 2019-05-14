using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Blogs
                .Select(i => new BlogModel()
                {
                    Id = i.Id,
                    Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                    Explanation = i.Explanation,
                    MainPage = i.MainPage,
                    Approve = i.Approve,
                    AddDate = i.AddDate
                })
                .Where(i => i.Approve == true && i.MainPage == true);
            //bloglar = bloglar.OrderByDescending(i=>)
             
            return View(bloglar.ToList()); //action ismi ne ise o isimde bir tane view i geri donderir yani index degerini dondurecek
        }
    }
}