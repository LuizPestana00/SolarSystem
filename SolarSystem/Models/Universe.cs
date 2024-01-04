using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class Universe
    {
        public Universe()
        {
            Galaxies = new HashSet<Galaxy>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Galaxy> Galaxies { get; set; }
    }
}
