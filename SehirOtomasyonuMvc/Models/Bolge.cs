using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SehirOtomasyonuMvc.Models.ViewModel
{
    public class Bolge
    {
        public int BolgeId { get; set; }

        [Display(Name = "Bolge Adı")]
        [Required(ErrorMessage = "Bolge Adı Giriniz", AllowEmptyStrings = false)] 
        public string BolgeAd { get; set; }
    }
}