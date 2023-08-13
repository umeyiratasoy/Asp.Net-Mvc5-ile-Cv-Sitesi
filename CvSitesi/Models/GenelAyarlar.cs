namespace CvSitesi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class GenelAyarlar
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Pp Fotoğraf Url alanı gereklidir.")]
        public string PpImage { get; set; }

        [Required(ErrorMessage = "İsim Soyisim alanı gereklidir.")]
        public string IsimSoyisim { get; set; }

        [StringLength(300, MinimumLength = 10, ErrorMessage = "{0} 10 karakterden az ve 300 karakterden fazla olamaz.")]
        [Required(ErrorMessage = "Biyografi alanı gereklidir.")]
        public string Biyografi { get; set; }

        [Required(ErrorMessage = "İnstagram alanı gereklidir.")]
        public string Instagram { get; set; }

        [Required(ErrorMessage = "Twitter alanı gereklidir.")]
        public string Twitter { get; set; }

        [Required(ErrorMessage = "Facebook alanı gereklidir.")]
        public string Facebook { get; set; }

        [Required(ErrorMessage = "Eposta alanı gereklidir."), EmailAddress(ErrorMessage = "Geçersiz Eposta girdiniz.")]
        public string Eposta { get; set; }
    }
}
