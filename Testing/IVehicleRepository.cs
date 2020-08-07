using ASP_NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET
{
    public interface IVehicleRepository
    {
        public IEnumerable<Insured> GetAllInsured();
    }
}
