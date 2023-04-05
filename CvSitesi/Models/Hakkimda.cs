namespace CvSitesi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Hakkimda
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir.")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        public string Aciklama { get; set; }
    }
}
