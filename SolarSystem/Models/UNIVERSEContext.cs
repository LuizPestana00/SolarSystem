using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SolarSystem.Models
{
    public partial class UNIVERSEContext : DbContext
    {
        public UNIVERSEContext()
        {
        }

        public UNIVERSEContext(DbContextOptions<UNIVERSEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SPResultPlanetBySS> SPResultPlanetBySSs { get; set; }
        public virtual DbSet<SpFindSS> SpResults { get; set; }
        public virtual DbSet<ChemComponent> ChemComponents { get; set; } = null!;
        public virtual DbSet<Flora> Floras { get; set; } = null!;
        public virtual DbSet<FloraBranch> FloraBranches { get; set; } = null!;
        public virtual DbSet<FloraFlower> FloraFlowers { get; set; } = null!;
        public virtual DbSet<FloraFoliage> FloraFoliages { get; set; } = null!;
        public virtual DbSet<FloraFruit> FloraFruits { get; set; } = null!;
        public virtual DbSet<FloraTrunk> FloraTrunks { get; set; } = null!;
        public virtual DbSet<FloraType> FloraTypes { get; set; } = null!;
        public virtual DbSet<Galaxy> Galaxies { get; set; } = null!;
        public virtual DbSet<Planet> Planets { get; set; } = null!;
        public virtual DbSet<PlanetAtmosphere> PlanetAtmospheres { get; set; } = null!;
        public virtual DbSet<PlanetComposition> PlanetCompositions { get; set; } = null!;
        public virtual DbSet<PlanetCore> PlanetCores { get; set; } = null!;
        public virtual DbSet<PlanetCrust> PlanetCrusts { get; set; } = null!;
        public virtual DbSet<PlanetDisk> PlanetDisks { get; set; } = null!;
        public virtual DbSet<PlanetSatelite> PlanetSatelites { get; set; } = null!;
        public virtual DbSet<PlanetSector> PlanetSectors { get; set; } = null!;
        public virtual DbSet<SolarSystem> SolarSystems { get; set; } = null!;
        public virtual DbSet<Universe> Universes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsetting.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("Universe");

            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChemComponent>(entity =>
            {
                entity.ToTable("ChemComponent", "Universe");

                entity.Property(e => e.Abundance).HasMaxLength(20);

                entity.Property(e => e.ComponentGroup).HasMaxLength(50);

                entity.Property(e => e.ComponentType)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.GenerateGroup).HasMaxLength(10);

                entity.Property(e => e.MainComponents).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Radioactive)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.RealComponent)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Symbol).HasMaxLength(20);

                entity.Property(e => e.Synthetic)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Flora>(entity =>
            {
                entity.ToTable("Flora", "Flora");

                entity.HasIndex(e => e.ScientificName, "IDXFloraScientificName")
                    .IsUnique();

                entity.Property(e => e.AutumnFoliageMaterial).HasMaxLength(25);

                entity.Property(e => e.AutumnTrunkBranchMaterial).HasMaxLength(25);

                entity.Property(e => e.BestMinAtmosphereGasPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CommonName).HasMaxLength(200);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.ReproductionCicle).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScientificName).HasMaxLength(200);

                entity.Property(e => e.SpringFoliageMaterial).HasMaxLength(25);

                entity.Property(e => e.SpringTrunkBranchMaterial).HasMaxLength(25);

                entity.Property(e => e.SummerFoliageMaterial).HasMaxLength(25);

                entity.Property(e => e.SummerTrunkBranchMaterial).HasMaxLength(25);

                entity.Property(e => e.WinterFoliageMaterial).HasMaxLength(25);

                entity.Property(e => e.WinterTrunkBranchMaterial).HasMaxLength(25);

                entity.Property(e => e.WorstMaxAtmosphereGasPercentage).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.AutumnFlower)
                    .WithMany(p => p.FloraAutumnFlowers)
                    .HasForeignKey(d => d.AutumnFlowerId)
                    .HasConstraintName("FK_Flora_AutumnFlower");

                entity.HasOne(d => d.AutumnFruit)
                    .WithMany(p => p.FloraAutumnFruits)
                    .HasForeignKey(d => d.AutumnFruitId)
                    .HasConstraintName("FK_Flora_AutumnFruit");

                entity.HasOne(d => d.BestAtmosphereGas)
                    .WithMany(p => p.FloraBestAtmosphereGas)
                    .HasForeignKey(d => d.BestAtmosphereGasId)
                    .HasConstraintName("FK_Flora_ChemComponentBest");

                entity.HasOne(d => d.FloraBranch)
                    .WithMany(p => p.Floras)
                    .HasForeignKey(d => d.FloraBranchId)
                    .HasConstraintName("FK_Flora_FloraBranch");

                entity.HasOne(d => d.FloraFoliage)
                    .WithMany(p => p.Floras)
                    .HasForeignKey(d => d.FloraFoliageId)
                    .HasConstraintName("FK_Flora_FloraFoliage");

                entity.HasOne(d => d.FloraTrunk)
                    .WithMany(p => p.Floras)
                    .HasForeignKey(d => d.FloraTrunkId)
                    .HasConstraintName("FK_Flora_FloraTrunk");

                entity.HasOne(d => d.FloraType)
                    .WithMany(p => p.Floras)
                    .HasForeignKey(d => d.FloraTypeId)
                    .HasConstraintName("FK_Flora_FloraType");

                entity.HasOne(d => d.SpringFlower)
                    .WithMany(p => p.FloraSpringFlowers)
                    .HasForeignKey(d => d.SpringFlowerId)
                    .HasConstraintName("FK_Flora_SpringFlower");

                entity.HasOne(d => d.SpringFruit)
                    .WithMany(p => p.FloraSpringFruits)
                    .HasForeignKey(d => d.SpringFruitId)
                    .HasConstraintName("FK_Flora_SpringFruit");

                entity.HasOne(d => d.SummerFlower)
                    .WithMany(p => p.FloraSummerFlowers)
                    .HasForeignKey(d => d.SummerFlowerId)
                    .HasConstraintName("FK_Flora_SummerFlower");

                entity.HasOne(d => d.SummerFruit)
                    .WithMany(p => p.FloraSummerFruits)
                    .HasForeignKey(d => d.SummerFruitId)
                    .HasConstraintName("FK_Flora_SummerFruit");

                entity.HasOne(d => d.WinterFlower)
                    .WithMany(p => p.FloraWinterFlowers)
                    .HasForeignKey(d => d.WinterFlowerId)
                    .HasConstraintName("FK_Flora_WinterFlower");

                entity.HasOne(d => d.WinterFruit)
                    .WithMany(p => p.FloraWinterFruits)
                    .HasForeignKey(d => d.WinterFruitId)
                    .HasConstraintName("FK_Flora_WinterFruit");

                entity.HasOne(d => d.WorstAtmosphereGas)
                    .WithMany(p => p.FloraWorstAtmosphereGas)
                    .HasForeignKey(d => d.WorstAtmosphereGasId)
                    .HasConstraintName("FK_Flora_ChemComponentWorst");
            });

            modelBuilder.Entity<FloraBranch>(entity =>
            {
                entity.ToTable("FloraBranch", "Flora");

                entity.Property(e => e.AssetId).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FloraType)
                    .WithMany(p => p.FloraBranches)
                    .HasForeignKey(d => d.FloraTypeId)
                    .HasConstraintName("FK_FloraBranch_FloraType");
            });

            modelBuilder.Entity<FloraFlower>(entity =>
            {
                entity.ToTable("FloraFlower", "Flora");

                entity.Property(e => e.AssetId).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FloraType)
                    .WithMany(p => p.FloraFlowers)
                    .HasForeignKey(d => d.FloraTypeId)
                    .HasConstraintName("FK_FloraFlower_FloraType");
            });

            modelBuilder.Entity<FloraFoliage>(entity =>
            {
                entity.ToTable("FloraFoliage", "Flora");

                entity.Property(e => e.AssetId).HasMaxLength(20);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FloraType)
                    .WithMany(p => p.FloraFoliages)
                    .HasForeignKey(d => d.FloraTypeId)
                    .HasConstraintName("FK_FloraFoliage_FloraType");
            });

            modelBuilder.Entity<FloraFruit>(entity =>
            {
                entity.ToTable("FloraFruit", "Flora");

                entity.Property(e => e.AssetId).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FloraType)
                    .WithMany(p => p.FloraFruits)
                    .HasForeignKey(d => d.FloraTypeId)
                    .HasConstraintName("FK_FloraFruit_FloraType");
            });

            modelBuilder.Entity<FloraTrunk>(entity =>
            {
                entity.ToTable("FloraTrunk", "Flora");

                entity.Property(e => e.AssetId).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FloraType)
                    .WithMany(p => p.FloraTrunks)
                    .HasForeignKey(d => d.FloraTypeId)
                    .HasConstraintName("FK_FloraTrunk_FloraType");
            });

            modelBuilder.Entity<FloraType>(entity =>
            {
                entity.ToTable("FloraType", "Flora");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Galaxy>(entity =>
            {
                entity.ToTable("Galaxy", "Universe");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Universe)
                    .WithMany(p => p.Galaxies)
                    .HasForeignKey(d => d.UniverseId)
                    .HasConstraintName("FK_Galaxy_Universe");
            });

            modelBuilder.Entity<Planet>(entity =>
            {
                entity.ToTable("Planet", "Universe");

                entity.HasIndex(e => e.SolarSystemId, "idx_Planet_SolarSystemId");

                entity.HasIndex(e => new { e.SolarSystemId, e.CommonName }, "idx_Planet_SolarSystemId_CommonName");

                entity.Property(e => e.AtmosphereRadius).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AtmosphereTexture).HasMaxLength(2);

                entity.Property(e => e.CommonName).HasMaxLength(100);

                entity.Property(e => e.CoreTexture).HasMaxLength(6);

                entity.Property(e => e.CoreType).HasMaxLength(20);

                entity.Property(e => e.DayDuration).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.OrbitalPeriod).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.ParamForSurfaceGeneration).HasMaxLength(100);

                entity.Property(e => e.PlanetRadius).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PlanetType).HasMaxLength(15);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScientificName).HasMaxLength(100);

                entity.Property(e => e.TemperatureVariation).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.Galaxy)
                    .WithMany(p => p.Planets)
                    .HasForeignKey(d => d.GalaxyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planet_Galaxy");

                entity.HasOne(d => d.SolarSystem)
                    .WithMany(p => p.Planets)
                    .HasForeignKey(d => d.SolarSystemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planet_SolarSystem");
            });

            modelBuilder.Entity<PlanetAtmosphere>(entity =>
            {
                entity.ToTable("PlanetAtmosphere", "Universe");

                entity.HasIndex(e => new { e.PlanetId, e.ChemComponentId }, "IX_PlanetAtmosphere_ChemComponentId")
                    .IsUnique();

                entity.HasIndex(e => e.PlanetId, "idx_PlanetAtmosphere_PlanetId");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChemComponent)
                    .WithMany(p => p.PlanetAtmospheres)
                    .HasForeignKey(d => d.ChemComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetAtmosphere_ChemComponent");

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetAtmospheres)
                    .HasForeignKey(d => d.PlanetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetAtmosphere_Planet");
            });

            modelBuilder.Entity<PlanetComposition>(entity =>
            {
                entity.ToTable("PlanetComposition", "Universe");

                entity.HasIndex(e => new { e.PlanetId, e.ChemComponentId }, "IX_PlanetComposition_ChemComponentId")
                    .IsUnique();

                entity.HasIndex(e => e.PlanetId, "idx_PlanetComposition_PlanetId");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChemComponent)
                    .WithMany(p => p.PlanetCompositions)
                    .HasForeignKey(d => d.ChemComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetComposition_ChemComponent");

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetCompositions)
                    .HasForeignKey(d => d.PlanetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetComposition_Planet");
            });

            modelBuilder.Entity<PlanetCore>(entity =>
            {
                entity.ToTable("PlanetCore", "Universe");

                entity.HasIndex(e => new { e.PlanetId, e.ChemComponentId }, "IX_PlanetCore_ChemComponentId")
                    .IsUnique();

                entity.HasIndex(e => e.PlanetId, "idx_PlanetCore_PlanetId");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChemComponent)
                    .WithMany(p => p.PlanetCores)
                    .HasForeignKey(d => d.ChemComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetCore_ChemComponent");

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetCores)
                    .HasForeignKey(d => d.PlanetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetCore_Planet");
            });

            modelBuilder.Entity<PlanetCrust>(entity =>
            {
                entity.ToTable("PlanetCrust", "Universe");

                entity.HasIndex(e => new { e.PlanetId, e.ChemComponentId }, "IX_PlanetCrust_ChemComponentId")
                    .IsUnique();

                entity.HasIndex(e => e.PlanetId, "idx_PlanetCrust_PlanetId");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChemComponent)
                    .WithMany(p => p.PlanetCrusts)
                    .HasForeignKey(d => d.ChemComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetCrust_ChemComponent");

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetCrusts)
                    .HasForeignKey(d => d.PlanetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetCrust_Planet");
            });

            modelBuilder.Entity<PlanetDisk>(entity =>
            {
                entity.ToTable("PlanetDisk", "Universe");

                entity.HasIndex(e => e.PlanetId, "idx_PlanetDisk_PlanetId");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.Dimension).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetDisks)
                    .HasForeignKey(d => d.PlanetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetDisk_Planet");
            });

            modelBuilder.Entity<PlanetSatelite>(entity =>
            {
                entity.ToTable("PlanetSatelite", "Universe");

                entity.HasIndex(e => e.PlanetId, "idx_PlanetSatelite_PlanetId");

                entity.HasIndex(e => new { e.PlanetId, e.CommonName }, "idx_PlanetSatelite_PlanetId_CommonName");

                entity.Property(e => e.AtmosphereTexture).HasMaxLength(1);

                entity.Property(e => e.CommonName).HasMaxLength(100);

                entity.Property(e => e.CoreTexture).HasMaxLength(3);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.Radius).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScientificName).HasMaxLength(100);

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetSatelites)
                    .HasForeignKey(d => d.PlanetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanetSatelite_Planet");
            });

            modelBuilder.Entity<PlanetSector>(entity =>
            {
                entity.ToTable("PlanetSector", "Universe");

                entity.HasIndex(e => new { e.PlanetId, e.X, e.Y }, "idx_PlanetSector")
                    .IsUnique();

                entity.HasIndex(e => new { e.PlanetId, e.X, e.Y, e.Z, e.Flat }, "idx_PlanetSector2");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Planet)
                    .WithMany(p => p.PlanetSectors)
                    .HasForeignKey(d => d.PlanetId)
                    .HasConstraintName("FK_PlanetSector_Planet");
            });

            modelBuilder.Entity<SolarSystem>(entity =>
            {
                entity.ToTable("SolarSystem", "Universe");

                entity.HasIndex(e => e.CommonName, "idx_SolarSystem_CommonName");

                entity.HasIndex(e => e.GalaxyId, "idx_SolarSystem_GalaxyId");

                entity.HasIndex(e => e.PlanetDistrib, "idx_SolarSystem_PlanetDistrib");

                entity.Property(e => e.CommonName).HasMaxLength(100);

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.PlanetDistrib)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.S1brightness).HasColumnName("S1Brightness");

                entity.Property(e => e.S1color)
                    .HasMaxLength(20)
                    .HasColumnName("S1Color");

                entity.Property(e => e.S1crown)
                    .HasMaxLength(2)
                    .HasColumnName("S1Crown");

                entity.Property(e => e.S1mass).HasColumnName("S1Mass");

                entity.Property(e => e.S1radius)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("S1Radius");

                entity.Property(e => e.S1surfaceTemp).HasColumnName("S1SurfaceTemp");

                entity.Property(e => e.S1texture)
                    .HasMaxLength(4)
                    .HasColumnName("S1Texture");

                entity.Property(e => e.S1type)
                    .HasMaxLength(20)
                    .HasColumnName("S1Type");

                entity.Property(e => e.S2brightness).HasColumnName("S2Brightness");

                entity.Property(e => e.S2color)
                    .HasMaxLength(20)
                    .HasColumnName("S2Color");

                entity.Property(e => e.S2crown)
                    .HasMaxLength(2)
                    .HasColumnName("S2Crown");

                entity.Property(e => e.S2mass).HasColumnName("S2Mass");

                entity.Property(e => e.S2orbit)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("S2Orbit");

                entity.Property(e => e.S2radius)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("S2Radius");

                entity.Property(e => e.S2surfaceTemp).HasColumnName("S2SurfaceTemp");

                entity.Property(e => e.S2texture)
                    .HasMaxLength(4)
                    .HasColumnName("S2Texture");

                entity.Property(e => e.S2type)
                    .HasMaxLength(20)
                    .HasColumnName("S2Type");

                entity.Property(e => e.ScientificName).HasMaxLength(100);

                entity.Property(e => e.SolarSystemType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Galaxy)
                    .WithMany(p => p.SolarSystems)
                    .HasForeignKey(d => d.GalaxyId)
                    .HasConstraintName("FK_SolarSystem_Galaxy");
            });

            modelBuilder.Entity<Universe>(entity =>
            {
                entity.ToTable("Universe", "Universe");

                entity.Property(e => e.DicaccKey)
                    .HasColumnName("DICAccKey")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DicaltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DICAltDate");

                entity.Property(e => e.DicaltOper)
                    .HasMaxLength(20)
                    .HasColumnName("DICAltOper");

                entity.Property(e => e.Dicstate)
                    .HasMaxLength(1)
                    .HasColumnName("DICState");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
