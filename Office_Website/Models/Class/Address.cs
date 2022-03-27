using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Office_Website.Models.Class
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Başlık { get; set; }
        public string openhours { get; set; }
        public string AcıkAdress { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }
        public string konum { get; set; }
    }
}