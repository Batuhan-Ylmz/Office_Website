using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Office_Website.Models.Class
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FotoUrl { get; set; }
        [AllowHtml]
        public string aciklama { get; set; }
        [AllowHtml]
        public string aciklama2 { get; set; }
    }
}