using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class FloraType
    {
        public FloraType()
        {
            FloraBranches = new HashSet<FloraBranch>();
            FloraFlowers = new HashSet<FloraFlower>();
            FloraFoliages = new HashSet<FloraFoliage>();
            FloraFruits = new HashSet<FloraFruit>();
            FloraTrunks = new HashSet<FloraTrunk>();
            Floras = new HashSet<Flora>();
        }

        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Observations { get; set; }

        public virtual ICollection<FloraBranch> FloraBranches { get; set; }
        public virtual ICollection<FloraFlower> FloraFlowers { get; set; }
        public virtual ICollection<FloraFoliage> FloraFoliages { get; set; }
        public virtual ICollection<FloraFruit> FloraFruits { get; set; }
        public virtual ICollection<FloraTrunk> FloraTrunks { get; set; }
        public virtual ICollection<Flora> Floras { get; set; }
    }
}
