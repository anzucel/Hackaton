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

        [HttpGet()]
        public IActionResult Problema3()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Problema3(string Cadena2, string Cadena1)
        {
            List<char> list_cadena1 = Cadena1.ToList<char>();
            List<char> list_cadena2 = Cadena2.ToList<char>();

            string subsecuente = "";
            if(Cadena1.Length == Cadena2.Length)
            {
                for (int i = 0; i < list_cadena1.Count; i++)
                {
                    if (list_cadena1[i] == list_cadena2[i])
                    {
                        subsecuente += list_cadena2[i];
                    }
                }
            }
            else
            {
                subsecuente = "El ejercicio no se puede realzar.";
            }

            ViewBag.Cadenas = "La palabra subsecuente es: " + Cadena1 + " " + "y" + " " + Cadena2 + " es: ";
            ViewBag.Resultado = subsecuente;
            return View("Problema3");
        }

        [HttpGet()]
        public IActionResult Problema4()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Problema4(string N, string num1, string num2)
        {
            int TotalN = Convert.ToInt32(N);
            int numero1 = Convert.ToInt32(num1);
            int numero2 = Convert.ToInt32(num2);

            int suma_num = numero1 + numero2;
            if(suma_num == TotalN)
            {
                List<char> numerobin1 = binario(numero1).ToList<char>();
                List<char> numerobin2 = binario(numero2).ToList<char>();

                int sumaavellanas = 0;
                for(int i=0; i<numerobin1.Count; i++)
                {
                    if(numerobin1[i] == '1')
                    {
                        sumaavellanas ++;
                    }

                }

                for (int i = 0; i < numerobin2.Count; i++)
                {
                    if (numerobin2[i] == '1')
                    {
                        sumaavellanas++;
                    }

                }

                ViewBag.Resultado = sumaavellanas;

            }
            else
            {
                ViewBag.Cadenas = "No podras recibir avellanas porque la suma no coincide";
            }

            return View("Problema3");
        }

        public string binario(int numero)
        {
            int mod;
            string binary = string.Empty;

            while (numero > 0)
            {
                mod = numero % 2;
                numero /= 2;
                binary = mod.ToString() + binary;
            }

            return binary;
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