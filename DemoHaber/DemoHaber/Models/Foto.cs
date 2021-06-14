using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Foto
    {
        [Key]
        public int FotoId { get; set; }
        public string FotoUrl { get; set; }
        public virtual Haber Haber { get; set; }
    }
}