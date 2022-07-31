using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Vasyliev_MVC.Models;

namespace Vasyliev_MVC.Controllers
{
    public class Base1Controller : Controller
    {
        private ILogger<Base1Controller> logger;
        public Base1Controller(ILogger<Base1Controller> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult View()
        {
            return View(new List<CarModel> {
                new CarModel {
                    Color= "Yellow",
                    Year = 2020,
                    Model = "BMW"
            } ,
                  new CarModel {
                    Color= "Blue",
                    Year = 2003,
                    Model = "Tavria"
            },
                    new CarModel {
                    Color= "Баклажан",
                    Year = 1990,
                    Model = "Lada"
            }
            });
        }
    }
}
