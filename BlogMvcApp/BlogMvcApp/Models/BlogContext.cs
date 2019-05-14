using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    //dbContext EF çatısı altında bulunur context e veritabanı yönetme özel. kazandırmak için kullanılır.
    //data.entity içerisinde
    public class BlogContext:DbContext
    {
        public BlogContext():base("blogvt")//eğer veri tabanının ismii değiştirmek istersen

        //bir connection string oluşturuldu ise 
        //public BlogContext() : base("blogDb")
        {
            //intiliazer ı uygulamaya tanıtmak için context ın constructorında çalıştırılır
            Database.SetInitializer(new BlogInitiliazer());
        }
        //tabloları temsil eder
        //context veri tabanı gibi kullanılır
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}