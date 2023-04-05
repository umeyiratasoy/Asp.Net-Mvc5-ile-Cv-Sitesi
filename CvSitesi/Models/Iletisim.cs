namespace CvSitesi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Iletisim
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanı gereklidir.")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Konu alanı gereklidir.")]
        public string Konu { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Eposta alanı gereklidir."), EmailAddress(ErrorMessage = "Ge\x00e7ersiz Eposta girdiniz. @ Kullanınız.")]
        public string Eposta { get; set; }
    }
}
