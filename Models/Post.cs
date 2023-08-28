using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _28_8_23_ASP.NET_MVC.Models
{

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string PublicationDate { get; set; }
        public string Author { get; set; }
    }
}