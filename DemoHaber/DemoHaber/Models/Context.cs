using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoHaber.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AltYorum> AltYorums { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Haber> Habers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

    }
}