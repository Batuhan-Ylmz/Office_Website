using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Office_Website.Models.Class
{
    public class ReplyClass
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string KullanıcıADI { get; set; }
        public string mail { get; set; }
        public string Cevap { get; set; }
        public int YorumID { get; set; }
        public virtual Comment Yorum { get; set; }
    }
}