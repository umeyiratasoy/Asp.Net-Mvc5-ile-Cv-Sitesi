using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CvSitesi.Models
{
    public class GenelAyarlar
    {
        [Key]
        public int ID { get; set; }
        public string PpImage { get; set; }
        public string IsimSoyisim { get; set; }
        public string Biyografi { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Eposta { get; set; }
    }
}