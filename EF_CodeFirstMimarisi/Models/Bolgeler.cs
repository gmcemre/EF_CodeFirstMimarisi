using System;
using System.Collections.Generic;

namespace EF_CodeFirstMimarisi.Models
{
    public partial class Bolgeler
    {
        public Bolgeler()
        {
            this.Personellers = new List<Personeller>();
        }

        public string TerritoryID { get; set; }
        public string TerritoryTanimi { get; set; }
        public int BolgeID { get; set; }
        public virtual Bolge Bolge { get; set; }
        public virtual ICollection<Personeller> Personellers { get; set; }
    }
}
