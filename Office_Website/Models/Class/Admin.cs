using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Office_Website.Models.Class
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public virtual bool remME { get; set; }
        public string AdminResmi { get; set; }
        public ICollection <Blog> Blogs { get; set; }
        public bool IsManager { get; set; }
    }
}