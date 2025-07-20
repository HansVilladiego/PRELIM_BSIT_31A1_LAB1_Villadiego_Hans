using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_BSIT_31A1_LAB1_Villadiego_Hans.Models;

namespace PRELIM_BSIT_31A1_LAB1_Villadiego_Hans.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            decimal tuitionFee = 15500.75m;
            decimal netFee = ComputeNetFee(tuitionFee, 10);
            ViewBag.NetFee = netFee;
            return View();
        }

        private decimal ComputeNetFee(decimal tuition, decimal discountPercent)
        {
            return tuition - (tuition * discountPercent / 100); 
        }
        public IActionResult AboutMe()
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
