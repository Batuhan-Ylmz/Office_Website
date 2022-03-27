using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Office_Website.Models.Class
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        [AllowHtml]
        public string Baslik { get; set; }
        [AllowHtml]
        public string aciklama { get; set; }
        public string BlogResmi { get; set; }
        public int KonuId { get; set; }
        public virtual Topic Konu { get; set; }
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public string substring { get; set; }
        public DateTime UpdadedAt { get; set; }
    }
}