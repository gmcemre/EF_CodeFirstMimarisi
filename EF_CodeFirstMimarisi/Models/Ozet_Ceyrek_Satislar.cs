using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class Ozet_Ceyrek_Satislar
    {
        public Nullable<System.DateTime> SevkTarihi { get; set; }
        public int SatisID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
