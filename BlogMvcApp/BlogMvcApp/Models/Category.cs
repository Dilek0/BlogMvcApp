using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Category
    {
        //ıd olarak veridiğinde bunu direk primary key olarak atar
        //eğer id ismi farklı verilmek istenirs örneğin kategori id gibi
        //başına [key] anahtar kelimesi konulur ve componentmodel.dataannotations sınıfı eklenir
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Blog> Blogs { get; set; }

    }
}