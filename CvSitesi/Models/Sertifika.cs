using System.ComponentModel.DataAnnotations;

namespace CvSitesi.Models
{
    public class Sertifika
    {
        [Key]
        public int ID { get; set; }
        public string SImage { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string SLink { get; set; }
    }
}