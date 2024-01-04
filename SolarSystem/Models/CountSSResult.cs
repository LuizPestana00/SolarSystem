using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class CountSSResult
    {
        public int TotalRows { get; set; }
        public int CountInRange { get; set; }
        public int CountOutOfRange { get; set; }
    }
}
