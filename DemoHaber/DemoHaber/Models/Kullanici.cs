using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
        public ICollection<AltYorum> AltYorums{ get; set; }
    }
}