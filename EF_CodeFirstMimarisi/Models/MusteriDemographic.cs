using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class MusteriDemographic
    {
        public MusteriDemographic()
        {
            this.Musterilers = new List<Musteriler>();
        }

        public string MusteriTypeID { get; set; }
        public string MusteriDesc { get; set; }
        public virtual ICollection<Musteriler> Musterilers { get; set; }
    }
}
