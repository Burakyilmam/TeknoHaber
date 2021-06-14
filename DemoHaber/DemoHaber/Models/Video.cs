using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; }
        public string VideoUrl { get; set; }
        public virtual Haber Haber { get; set; }
    }
}