using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class AltYorum
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumYazi { get; set; }
        public DateTime YorumEklenmeTarihi { get; set; }
        public virtual Haber Haber { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Yorum Yorum { get; set; }
    }
}