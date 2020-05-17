using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SehirOtomasyonuMvc.Models.ViewModel
{
    public class BolgeviewModel
    {
        public Bolge bhr { get; set; }
        public IEnumerable<Bolge> Bolgeler { get; set; }
    }
}