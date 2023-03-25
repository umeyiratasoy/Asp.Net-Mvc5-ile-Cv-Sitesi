using System.ComponentModel.DataAnnotations;

namespace CvSitesi.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
    }
}