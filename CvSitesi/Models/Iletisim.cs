using System.ComponentModel.DataAnnotations;

namespace CvSitesi.Models
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanı gereklidir.")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Eposta alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz Eposta girdiniz.")]
        public string Eposta { get; set; }
    }
}