using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CvSitesi.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins  { get; set; }
        public DbSet<Egitim> Egitims  { get; set; }
        public DbSet<GenelAyarlar> GenelAyarlars  { get; set; }
        public DbSet<Hakkimda> Hakkimdas  { get; set; }
        public DbSet<Iletisim> Iletisims  { get; set; }
        public DbSet<Sertifika> Sertifikas  { get; set; }
    }
}