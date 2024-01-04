using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class FloraFruit
    {
        public FloraFruit()
        {
            FloraAutumnFruits = new HashSet<Flora>();
            FloraSpringFruits = new HashSet<Flora>();
            FloraSummerFruits = new HashSet<Flora>();
            FloraWinterFruits = new HashSet<Flora>();
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
        public virtual ICollection<Flora> FloraAutumnFruits { get; set; }
        public virtual ICollection<Flora> FloraSpringFruits { get; set; }
        public virtual ICollection<Flora> FloraSummerFruits { get; set; }
        public virtual ICollection<Flora> FloraWinterFruits { get; set; }
    }
}
