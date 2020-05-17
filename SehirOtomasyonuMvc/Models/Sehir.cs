using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SehirOtomasyonuMvc.Models
{
    public class Sehir
    {
        public int SehirId { get; set; }

        [Display(Name = "Sehir Adı")]
        [Required(ErrorMessage = "Sehir Adı Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string SehirAd{ get; set; }

        [Display(Name = "Sehir Tarihi eser")]
        [Required(ErrorMessage = "Sehir Tarihi eser Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string TarihiEser { get; set; }

       
    }
}