using System.ComponentModel.DataAnnotations;

namespace CvSitesi.Models
{
    public class Egitim
    {
        [Key]
        public int ID { get; set; }
        public string OkulAdi { get; set; }
        public string BolumAdi { get; set; }
    }
}