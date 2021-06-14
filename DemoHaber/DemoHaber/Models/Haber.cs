using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Haber
    {
        [Key]
        public int HaberId { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberKapakFoto { get; set; }
        public string HaberYazi { get; set; }
        public DateTime HaberEklenmeTarihi { get; set; }
        public virtual Kategori Kategori { get; set; }
        public ICollection<Foto> Fotos { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
        public virtual Admin Admin { get; set; }
    }
}