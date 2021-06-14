using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminAd { get; set; }
        public int AdminSifre { get; set; }
        public ICollection<Haber> Habers { get; set; }
    }
}