using System;
using System.Collections.Generic;

namespace SolarSystem.Models
{
    public partial class Flora
    {
        public Guid DicaccKey { get; set; }
        public string? Dicstate { get; set; }
        public DateTime? DicaltDate { get; set; }
        public string? DicaltOper { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Id { get; set; }
        public string? ScientificName { get; set; }
        public string? CommonName { get; set; }
        public int? OptimalTemperature { get; set; }
        public int? OptimalAltitude { get; set; }
        public int? BestAtmosphereGasId { get; set; }
        public decimal? BestMinAtmosphereGasPercentage { get; set; }
        public int? WorstAtmosphereGasId { get; set; }
        public decimal? WorstMaxAtmosphereGasPercentage { get; set; }
        public int? MaxWidth { get; set; }
        public int? MaxHeight { get; set; }
        public int? ExclusiveRadius { get; set; }
        public int? Longevity { get; set; }
        public decimal? ReproductionCicle { get; set; }
        public int? FloraTypeId { get; set; }
        public int? FloraTrunkId { get; set; }
        public int? FloraBranchId { get; set; }
        public string? SpringTrunkBranchMaterial { get; set; }
        public string? SummerTrunkBranchMaterial { get; set; }
        public string? AutumnTrunkBranchMaterial { get; set; }
        public string? WinterTrunkBranchMaterial { get; set; }
        public int? FloraFoliageId { get; set; }
        public string? SpringFoliageMaterial { get; set; }
        public string? SummerFoliageMaterial { get; set; }
        public string? AutumnFoliageMaterial { get; set; }
        public string? WinterFoliageMaterial { get; set; }
        public int? SpringFlowerId { get; set; }
        public int? SummerFlowerId { get; set; }
        public int? AutumnFlowerId { get; set; }
        public int? WinterFlowerId { get; set; }
        public int? SpringFruitId { get; set; }
        public int? SummerFruitId { get; set; }
        public int? AutumnFruitId { get; set; }
        public int? WinterFruitId { get; set; }

        public virtual FloraFlower? AutumnFlower { get; set; }
        public virtual FloraFruit? AutumnFruit { get; set; }
        public virtual ChemComponent? BestAtmosphereGas { get; set; }
        public virtual FloraBranch? FloraBranch { get; set; }
        public virtual FloraFoliage? FloraFoliage { get; set; }
        public virtual FloraTrunk? FloraTrunk { get; set; }
        public virtual FloraType? FloraType { get; set; }
        public virtual FloraFlower? SpringFlower { get; set; }
        public virtual FloraFruit? SpringFruit { get; set; }
        public virtual FloraFlower? SummerFlower { get; set; }
        public virtual FloraFruit? SummerFruit { get; set; }
        public virtual FloraFlower? WinterFlower { get; set; }
        public virtual FloraFruit? WinterFruit { get; set; }
        public virtual ChemComponent? WorstAtmosphereGas { get; set; }
    }
}
