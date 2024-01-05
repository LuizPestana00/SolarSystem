using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SolarSystem.Models;
using Dapper;

namespace SolarSystem.classes
{
    internal class controllerSS
    {
        UNIVERSEContext db;

        public (List<SpFindSS> result1, CountSSResult result2) CallStoredProcedureSS()
        {
            using (var db = new UNIVERSEContext())
            {
                var connection = db.Database.GetDbConnection();

                // Executar a stored procedure e obter os resultados
                var results = connection.QueryMultiple("Universe.FindSolarSystem",
                    new
                    {
                        X = 50000,
                        Y = 50000,
                        Z = 50000,
                        Amplitude = 30000,
                        Range = 18000
                    },
                    commandType: CommandType.StoredProcedure);

                // Result1: Valores do primeiro SELECT
                var result1 = results.Read<SpFindSS>().ToList();

                // Result2: Valores do segundo SELECT
                var result2 = results.Read<CountSSResult>().FirstOrDefault();

                return (result1, result2);
            }
        }

        public (List<SpFindSS> result1, CountSSResult result2) CallStoredProcedureSS(long X, long Y, long Z, long Amplitude, long Range)
        {
            using (var db = new UNIVERSEContext())
            {
                var connection = db.Database.GetDbConnection();

                // Executar a stored procedure e obter os resultados
                var results = connection.QueryMultiple("Universe.FindSolarSystem",
                    new
                    {
                        X = X,
                        Y = Y,
                        Z = Z,
                        Amplitude = Amplitude,
                        Range = Range
                    },
                    commandType: CommandType.StoredProcedure);

                // Result1: Valores do primeiro SELECT
                var result1 = results.Read<SpFindSS>().ToList();

                // Result2: Valores do segundo SELECT
                var result2 = results.Read<CountSSResult>().FirstOrDefault();

                return (result1, result2);
            }
        }

        public object CallSPFindPlanetsBySS(int ss)
        {
            using (var db = new UNIVERSEContext())
            {
                var parameter = new SqlParameter("@SS", ss);
                var result = db.SPResultPlanetBySSs.FromSqlInterpolated($"EXEC Universe.ShowPlanetsInfosBySS {ss}").ToList();
                return result;
            }
        }

        public object Satelites(long id)
        {
            using (var db = new UNIVERSEContext())
            {
                var query = from PlanetSatelite in db.PlanetSatelites
                            where PlanetSatelite.PlanetId == id
                            select new
                            {
                                Id = PlanetSatelite.Id,
                                ScienName = PlanetSatelite.ScientificName,
                                CommonName = PlanetSatelite.CommonName,
                                Radius = PlanetSatelite.Radius,
                                DistanceToPlanet = PlanetSatelite.DistanceToPlanet,
                                OrbitAngle = PlanetSatelite.OrbitAngle,
                                CoreTexture = PlanetSatelite.CoreTexture,
                                AtmosphereTexture = PlanetSatelite.AtmosphereTexture,
                                ColorHue = PlanetSatelite.ColorHue,
                                ColorSat = PlanetSatelite.ColorSat,
                                ColorLum = PlanetSatelite.ColorLum,
                                ColorRed = PlanetSatelite.ColorRed,
                                ColorBlue = PlanetSatelite.ColorBlue,
                                ColorGreen = PlanetSatelite.ColorGreen,
                            };
                return query.ToList();
            }
        }

        public object Disks(long id)
        {
            using (var db = new UNIVERSEContext())
            {
                var query = from PlanetDisk in db.PlanetDisks
                            where PlanetDisk.PlanetId == id
                            select new
                            {
                                Id = PlanetDisk.Id,
                                Dimension = PlanetDisk.Dimension,
                                DistanceToPlanet = PlanetDisk.DistanceToPlanet,
                                OrbitAngle = PlanetDisk.OrbitAngle,
                                ColorHue = PlanetDisk.ColorHue,
                                ColorSat = PlanetDisk.ColorSat,
                                ColorLum = PlanetDisk.ColorLum,
                                ColorBlue = PlanetDisk.ColorBlue,
                                ColorGreen = PlanetDisk.ColorGreen,
                                ColorRed = PlanetDisk.ColorRed
                            };
                return query.ToList();
            }
        }

        public object Composition(long id)
        {
            using (var db = new UNIVERSEContext())
            {
                var query = from pc in db.PlanetCompositions
                            join cc in db.ChemComponents on pc.ChemComponentId equals cc.Id
                            where pc.PlanetId == id
                            select new
                            {
                                ComponentId = cc.Id,
                                Name = cc.Name,
                                Symbol = cc.Symbol,
                                MainComponents = cc.MainComponents,
                                Percentage = pc.Percentage
                            };
                return query.ToList();
            }
        }

        public object Atmosphere(long id) 
        { 
            using (var db = new UNIVERSEContext())
            {
                var query = from a in db.PlanetAtmospheres
                            join cc in db.ChemComponents on a.ChemComponentId equals cc.Id
                            where a.PlanetId == id
                            select new
                            {
                                ComponentId = cc.Id,
                                Name = cc.Name,
                                Symbol = cc.Symbol,
                                MainComponents = cc.MainComponents,
                                Percentage = a.Percentage
                            };
                return query.ToList();
            }
        }

        public object Crust(long id)
        {
            using (var db = new UNIVERSEContext())
            {
                var query = from c in db.PlanetCrusts
                            join cc in db.ChemComponents on c.ChemComponentId equals cc.Id
                            where c.PlanetId == id
                            select new
                            {
                                ComponentId = cc.Id,
                                Name = cc.Name,
                                Symbol = cc.Symbol,
                                MainComponents = cc.MainComponents,
                                Percentage = c.Percentage
                            };
                var result = query.ToList();
                if (result.Any())
                    return result;
                else
                    return null;
            }
        }
        public object Core(long id)
        {
            using (var db = new UNIVERSEContext())
            {
                var query = from c in db.PlanetCores
                            join cc in db.ChemComponents on c.ChemComponentId equals cc.Id
                            where c.PlanetId == id
                            select new
                            {
                                ComponentId = cc.Id,
                                Name = cc.Name,
                                Symbol = cc.Symbol,
                                MainComponents = cc.MainComponents,
                                Percentage = c.Percentage
                            };
                var result = query.ToList();
                if (result.Any())
                    return result;
                else
                    return null;
            }
        }
    }
}
