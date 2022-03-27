using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Office_Website.Models.Class
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string AD { get; set; }
        public string Mail { get; set; }
        public string telefon { get; set; }
        public string Konu { get; set; }
        [UIHint("MultilineText")]
        public string Mesaj { get; set; }
    }
}