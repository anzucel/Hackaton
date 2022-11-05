using Hackaton2022.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hackaton2022.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Privacy(string paragraph)
        {
            if (paragraph != null)
            {
                string[] newParagraph = paragraph.Split("\r\n");
                for (int i = 0; i < newParagraph.Length; i++)
                {
                    if(newParagraph[i].Length < 16)
                    {

                    }
                }

                return View("Privacy");
            }
            else
            {
                return View("Privacy");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}