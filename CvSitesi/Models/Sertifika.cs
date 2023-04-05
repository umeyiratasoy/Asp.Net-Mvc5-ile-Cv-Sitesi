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

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Sertifika Linki alanı gereklidir.")]
        public string SLink { get; set; }
    }
}
