using System;
using System.Collections.Generic;
using System.Data.Entity;//initiliazer için
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    //buradaki amaç model değişirse drop create ile context içindeki tabloları 
    //veri tabanından siler ver yeniden oluşturur
    public class BlogInitiliazer:DropCreateDatabaseAlways<BlogContext>
    {
        //seed metodu test veileri ekleme imkanı sağlar
        protected override void Seed(BlogContext context)
        {
            List<Category> Categories = new List<Category>()
            {
                new Category(){CategoryName = "c#"},
                new Category(){CategoryName = "java"},
                new Category(){CategoryName = "android"},
                new Category(){CategoryName = "asp.net"},
                new Category(){CategoryName = "c++"},
                new Category(){CategoryName = "mvc"}
            };

            foreach (var item in Categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            List<Blog> Blogs = new List<Blog>()
            {
                new Blog(){Baslik = "c# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkındac# delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-10), MainPage = true, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 1},
                new Blog(){Baslik= "java delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-5), MainPage = true, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 2},
                new Blog(){Baslik = "c++ delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-3), MainPage = true, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 3},
                new Blog(){Baslik= "android delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-13), MainPage = true, Approve = false, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 4},
                new Blog(){Baslik= "c# delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-1), MainPage = false, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 2},
                new Blog(){Baslik= "c# delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-2), MainPage = true, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 3},
                new Blog(){Baslik= "c# delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-6), MainPage = true, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 4},
                new Blog(){Baslik= "c# delegates hakkında", Explanation = "delegates hakkında", AddDate = DateTime.Now.AddDays(-30), MainPage = false, Approve = true, Content="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CategoryId = 2},

            };

            foreach (var i in Blogs)
            {
                context.Blogs.Add(i);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}