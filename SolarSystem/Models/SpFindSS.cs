using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class SpFindSS
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public string? ScientificName { get; set; }
        public string? CommonName { get; set; }
        public char? SolarSystemType { get; set; }
        public int? SolarSystemAge { get; set; }
        public int? PlanetCount { get; set; }
        public long? Distance { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }
        public string InRange { get; set; }
        public string? S1Type { get; set; }
		public float? S1Mass { get; set; }
		public int? S1SurfaceTemp { get; set; }
		public int? S1Brightness { get; set; }
		public double? S1Radius { get; set; }
		public string? S1Color { get; set; }
		public string? S1Texture { get; set; }
		public string? S1Crown { get; set; }
        public string? S2Type { get; set; }
        public float? S2Mass { get; set; }
        public int? S2SurfaceTemp { get; set; }
        public int? S2Brightness { get; set; }
        public double? S2Radius { get; set; }
        public string? S2Color { get; set; }
        public string? S2Texture { get; set; }
        public string? S2Crown { get; set; }
    }
}
