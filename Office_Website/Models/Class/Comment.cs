using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Office_Website.Models.Class
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        // kendinimiz insert olurken vericez.
        public DateTime CreatedAt { get; set; }
        public string KullanıcıADI { get; set; }
        [Required]
        public string mail { get; set; }
        [Required]
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<ReplyClass> ReplyClasses { get; set; }
    }
}