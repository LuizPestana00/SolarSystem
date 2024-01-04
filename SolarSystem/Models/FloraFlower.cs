using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class FloraFlower
    {
        public FloraFlower()
        {
            FloraAutumnFlowers = new HashSet<Flora>();
            FloraSpringFlowers = new HashSet<Flora>();
            FloraSummerFlowers = new HashSet<Flora>();
            FloraWinterFlowers = new HashSet<Flora>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public int? FloraTypeId { get; set; }
        public string? Description { get; set; }
        public string? AssetId { get; set; }

        public virtual FloraType? FloraType { get; set; }
        public virtual ICollection<Flora> FloraAutumnFlowers { get; set; }
        public virtual ICollection<Flora> FloraSpringFlowers { get; set; }
        public virtual ICollection<Flora> FloraSummerFlowers { get; set; }
        public virtual ICollection<Flora> FloraWinterFlowers { get; set; }
    }
}
