using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class Kategorilere_Gore_Satislar
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<decimal> Urunlerales { get; set; }
    }
}
