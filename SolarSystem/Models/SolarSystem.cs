using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class SolarSystem
    {
        public SolarSystem()
        {
            Planets = new HashSet<Planet>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public string? ScientificName { get; set; }
        public string? CommonName { get; set; }
        public int? GalaxyId { get; set; }
        public string? SolarSystemType { get; set; }
        public int? SolarSystemAge { get; set; }
        public string? S1type { get; set; }
        public double? S1mass { get; set; }
        public int? S1surfaceTemp { get; set; }
        public int? S1brightness { get; set; }
        public decimal? S1radius { get; set; }
        public string? S1color { get; set; }
        public string? S1texture { get; set; }
        public string? S1crown { get; set; }
        public string? S2type { get; set; }
        public double? S2mass { get; set; }
        public int? S2surfaceTemp { get; set; }
        public int? S2brightness { get; set; }
        public decimal? S2radius { get; set; }
        public string? S2color { get; set; }
        public string? S2texture { get; set; }
        public string? S2crown { get; set; }
        public decimal? S2orbit { get; set; }
        public string? PlanetDistrib { get; set; }
        public long? Distance { get; set; }
        public long? X { get; set; }
        public long? Y { get; set; }
        public long? Z { get; set; }

        public virtual Galaxy? Galaxy { get; set; }
        public virtual ICollection<Planet> Planets { get; set; }
    }
}
