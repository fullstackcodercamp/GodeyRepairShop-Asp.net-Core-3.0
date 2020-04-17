using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GodeyCarRepairShop.Models;

namespace GodeyCarRepairShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CarRepairDbContext Database { get; }

        public HomeController(ILogger<HomeController> logger, CarRepairDbContext database)
        {
            _logger = logger;
            Database = database;
        }

        public IActionResult Index( string searchValue)
        {
            var services = Database.Services.ToList();
            if (!string.IsNullOrEmpty(searchValue))
            {
                services = services.Where(x => x.ServiceName.ToLower().Contains(searchValue.ToLower()) || x.Description.ToLower().Contains(searchValue.ToLower())).ToList();
            }

            return View(services);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
