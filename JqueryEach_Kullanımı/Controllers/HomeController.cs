using JqueryEach_Kullanımı.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JqueryEach_Kullanımı.Controllers
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
            return View();
        }

        [HttpPost]
        public JsonResult Index(string junk) {



            List<string> city = new List<string>() { "İstanbul", "Ankara", "İzmir", "Konya", "Kayseri", "İzmit", "Erzurum", "Muğla" };


            return Json(city);


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