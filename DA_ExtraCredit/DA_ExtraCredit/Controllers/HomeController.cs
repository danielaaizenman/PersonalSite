using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.IO;
namespace DA_ExtraCredit.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        //TODO: Create a new action method for the new page
        public IActionResult ATXRecommendations()
        {
            return View();
        }


        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Aizenman.Daniela.Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Aizenman.Daniela.Resume.pdf");
        }
    }
}


