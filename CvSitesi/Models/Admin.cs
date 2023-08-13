namespace CvSitesi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Eposta alanı gereklidir."), EmailAddress(ErrorMessage = "Geçersiz Eposta girdiniz.")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Sifre { get; set; }
    }
}
