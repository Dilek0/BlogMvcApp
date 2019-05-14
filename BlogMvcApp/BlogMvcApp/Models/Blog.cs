using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string  Baslik { get; set; }
        public string Explanation { get; set; }
        public string Content { get; set; }
        public DateTime AddDate { get; set; }//burada datetime için illa bir değer isteniyor.

        //bool degerler nullable olamaz o yuzden varsayılan olarak false atanacak
        public bool Approve { get; set; }
        public bool MainPage { get; set; }

        //her blog kategoriye ait
        //navigation property
        //her blog bir kategoriye aittir.
        public int CategoryId{ get; set; }//yabancı anahtar
        public Category Category { get; set; }
    }
}