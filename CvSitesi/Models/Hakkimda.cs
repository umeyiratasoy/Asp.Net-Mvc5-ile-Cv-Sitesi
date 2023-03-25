using System.ComponentModel.DataAnnotations;

namespace CvSitesi.Models
{
    public class Hakkimda
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}