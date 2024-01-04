using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class PlanetDisk
    {
        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public long Id { get; set; }
        public long PlanetId { get; set; }
        public decimal? Dimension { get; set; }
        public int? DistanceToPlanet { get; set; }
        public int? OrbitAngle { get; set; }
        public int? ColorHue { get; set; }
        public int? ColorSat { get; set; }
        public int? ColorLum { get; set; }
        public int? ColorRed { get; set; }
        public int? ColorGreen { get; set; }
        public int? ColorBlue { get; set; }

        public virtual Planet Planet { get; set; } = null!;
    }
}
