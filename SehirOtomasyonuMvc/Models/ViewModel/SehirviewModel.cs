using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SehirOtomasyonuMvc.Models.ViewModel
{
    public class SehirviewModel
    {
        public Sehir Shr { get; set; }
        public IEnumerable<Sehir> Sehirler { get; set; }
    }
}