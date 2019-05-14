using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Explanation { get; set; }
       
        public DateTime AddDate { get; set; }
        public bool Approve { get; set; }
        public bool MainPage { get; set; }
    }
}