namespace CvSitesi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Egitim
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Okul Adı alanı gereklidir.")]
        public string OkulAdi { get; set; }

        [Required(ErrorMessage = "Bölüm Adı alanı gereklidir.")]
        public string BolumAdi { get; set; }
    }
}
