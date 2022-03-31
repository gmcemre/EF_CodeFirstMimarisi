using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class UrunResim
    {
        public int Id { get; set; }
        public int UrunID { get; set; }
        public byte[] Resim { get; set; }
        public bool IsActive { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
