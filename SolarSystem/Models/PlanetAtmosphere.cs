using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class PlanetAtmosphere
    {
        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public long Id { get; set; }
        public long PlanetId { get; set; }
        public int ChemComponentId { get; set; }
        public int? Percentage { get; set; }

        public virtual ChemComponent ChemComponent { get; set; } = null!;
        public virtual Planet Planet { get; set; } = null!;
    }
}
