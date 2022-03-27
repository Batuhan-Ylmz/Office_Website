using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Office_Website.Models.Class
{
    public class BlogComments
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Comment> Deger2 { get; set; }
        public IEnumerable<ReplyClass> Deger3 {get ; set ;}
       
    }
}