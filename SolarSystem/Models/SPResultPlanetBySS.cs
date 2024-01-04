using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class SPResultPlanetBySS
    {
        public string SSCommonName { get; set; }
        public long Id { get; set; }
        public string? ScientificName { get; set; }
        public string? PCommonName { get; set; }
        public decimal? PlanetRadius { get; set; }
        public double? PlanetMass { get; set; }
        public double? PlanetDensity { get; set; }
        public double? PlanetGravity { get; set; }
        public decimal? AtmosphereRadius { get; set; }
        public string? AtmosphereTexture { get; set; }
        public int? DistanceToStar { get; set; }
        public int? AxisAngle { get; set; }
        public int? OrbitAngle { get; set; }
        public decimal? DayDuration { get; set; }
        public decimal? OrbitalPeriod { get; set; }
        public int? AverageTemperature { get; set; }
        public decimal? TemperatureVariation { get; set; }
        public string? CoreType { get; set; }
        public string? CoreTexture { get; set; }
        public string? PlanetType { get; set; }
        public int DiskCount { get; set; }
        public int SateliteCount { get; set; }
    }

}
