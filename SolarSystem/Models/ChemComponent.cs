using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class ChemComponent
    {
        public ChemComponent()
        {
            FloraBestAtmosphereGas = new HashSet<Flora>();
            FloraWorstAtmosphereGas = new HashSet<Flora>();
            PlanetAtmospheres = new HashSet<PlanetAtmosphere>();
            PlanetCompositions = new HashSet<PlanetComposition>();
            PlanetCores = new HashSet<PlanetCore>();
            PlanetCrusts = new HashSet<PlanetCrust>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public string? ComponentGroup { get; set; }
        public int? AtomicNumber { get; set; }
        public double? AtomicMass { get; set; }
        public double? MeltingCelsius { get; set; }
        public double? BoilingCelsius { get; set; }
        public int? ColorHue { get; set; }
        public int? ColorSat { get; set; }
        public int? ColorLum { get; set; }
        public int? ColorRed { get; set; }
        public int? ColorGreen { get; set; }
        public int? ColorBlue { get; set; }
        public string? Abundance { get; set; }
        public string? Synthetic { get; set; }
        public string? Radioactive { get; set; }
        public string? RealComponent { get; set; }
        public string? ComponentType { get; set; }
        public string? MainComponents { get; set; }
        public string? GenerateGroup { get; set; }

        public virtual ICollection<Flora> FloraBestAtmosphereGas { get; set; }
        public virtual ICollection<Flora> FloraWorstAtmosphereGas { get; set; }
        public virtual ICollection<PlanetAtmosphere> PlanetAtmospheres { get; set; }
        public virtual ICollection<PlanetComposition> PlanetCompositions { get; set; }
        public virtual ICollection<PlanetCore> PlanetCores { get; set; }
        public virtual ICollection<PlanetCrust> PlanetCrusts { get; set; }
    }
}
