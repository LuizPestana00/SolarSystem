using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class Planet
    {
        public Planet()
        {
            PlanetAtmospheres = new HashSet<PlanetAtmosphere>();
            PlanetCompositions = new HashSet<PlanetComposition>();
            PlanetCores = new HashSet<PlanetCore>();
            PlanetCrusts = new HashSet<PlanetCrust>();
            PlanetDisks = new HashSet<PlanetDisk>();
            PlanetSatelites = new HashSet<PlanetSatelite>();
            PlanetSectors = new HashSet<PlanetSector>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public long Id { get; set; }
        public int GalaxyId { get; set; }
        public int SolarSystemId { get; set; }
        public string? ScientificName { get; set; }
        public string? CommonName { get; set; }
        public decimal? PlanetRadius { get; set; }
        public double? PlanetMass { get; set; }
        public double? PlanetDensity { get; set; }
        public double? PlanetGravity { get; set; }
        public decimal? AtmosphereRadius { get; set; }
        public int? DistanceToStar { get; set; }
        public int? AxisAngle { get; set; }
        public int? OrbitAngle { get; set; }
        public decimal? DayDuration { get; set; }
        public decimal? OrbitalPeriod { get; set; }
        public int? AverageTemperature { get; set; }
        public decimal? TemperatureVariation { get; set; }
        public int? SateliteNum { get; set; }
        public int? DiskNum { get; set; }
        public double? SeasonSeed { get; set; }
        public double? DaySeed { get; set; }
        public string? CoreType { get; set; }
        public string? CoreTexture { get; set; }
        public string? AtmosphereTexture { get; set; }
        public string? ParamForSurfaceGeneration { get; set; }
        public string? PlanetType { get; set; }

        public virtual Galaxy Galaxy { get; set; } = null!;
        public virtual SolarSystem SolarSystem { get; set; } = null!;
        public virtual ICollection<PlanetAtmosphere> PlanetAtmospheres { get; set; }
        public virtual ICollection<PlanetComposition> PlanetCompositions { get; set; }
        public virtual ICollection<PlanetCore> PlanetCores { get; set; }
        public virtual ICollection<PlanetCrust> PlanetCrusts { get; set; }
        public virtual ICollection<PlanetDisk> PlanetDisks { get; set; }
        public virtual ICollection<PlanetSatelite> PlanetSatelites { get; set; }
        public virtual ICollection<PlanetSector> PlanetSectors { get; set; }
    }
}
