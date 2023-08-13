namespace CvSitesi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Sertifika
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Sertifika Fotoğrafı  gereklidir.")]
        public string SImage { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir.")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Açıklama Linki alanı gereklidir.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "{0} 10 karakterden az ve 200 karakterden fazla olamaz.")]
        public string Aciklama { get; set; }

        [StringLength(999, MinimumLength = 30, ErrorMessage = "{0} 30 karakterden az ve 999 karakterden fazla olamaz.")]
        [Required(ErrorMessage = "Sertifika Linki alanı gereklidir.")]
        public string SLink { get; set; }
    }
}
