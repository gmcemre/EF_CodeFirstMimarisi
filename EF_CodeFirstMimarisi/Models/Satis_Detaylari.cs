using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class Satis_Detaylari
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public decimal BirimFiyati { get; set; }
        public short Miktar { get; set; }
        public float İndirim { get; set; }
        public virtual Satislar Satislar { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
