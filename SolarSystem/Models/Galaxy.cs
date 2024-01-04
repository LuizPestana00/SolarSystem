using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class Galaxy
    {
        public Galaxy()
        {
            Planets = new HashSet<Planet>();
            SolarSystems = new HashSet<SolarSystem>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? UniverseId { get; set; }

        public virtual Universe? Universe { get; set; }
        public virtual ICollection<Planet> Planets { get; set; }
        public virtual ICollection<SolarSystem> SolarSystems { get; set; }
    }
}
