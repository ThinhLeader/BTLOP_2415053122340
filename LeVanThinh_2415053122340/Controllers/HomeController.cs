using System.Diagnostics;
using LeVanThinh_2415053122340.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeVanThinh_2415053122340.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var sinhVien = new SinhVien
            {
                Id = "SV001",
                Name = "Le Van Thinh"
            };
            return View(sinhVien);
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
