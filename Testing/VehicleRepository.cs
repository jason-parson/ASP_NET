using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using ASP_NET.Models;
using Dapper;

namespace ASP_NET
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDbConnection _conn;
        public VehicleRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Insured> GetAllInsured()
        {
            return _conn.Query<Insured>("SELECT * FROM INSURED;");
        }
    }
}
