using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public ICollection<Haber> Habers { get; set; }
    }
}