using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class PlanetSector
    {
        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public long Id { get; set; }
        public long? PlanetId { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public double? Z { get; set; }
        public bool? Flat { get; set; }
        public short? Noise { get; set; }

        public virtual Planet? Planet { get; set; }
    }
}
