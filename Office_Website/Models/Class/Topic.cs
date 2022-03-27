using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Office_Website.Models.Class
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string KonuAD { get; set; }
        [AllowHtml]
        public string KonuAciklama { get; set; }
        public string KonuResim { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}