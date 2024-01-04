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
    }
}
