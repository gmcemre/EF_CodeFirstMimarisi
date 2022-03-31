using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class PersonelRapor
    {
        public string Adi { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<double> ToplamTutar { get; set; }
    }
}
