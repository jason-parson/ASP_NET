using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository repo;

        public VehicleController(IVehicleRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var insured = repo.GetAllInsured();

            return View(insured);
        }

    }
}
