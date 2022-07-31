using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Vasyliev_MVC.Models;

namespace Vasyliev_MVC.Controllers
{
    public class Base2Controller : Controller
    {
        private ILogger<Base2Controller> logger;
        public Base2Controller(ILogger<Base2Controller> logger)
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
                    Model = "Mersedes"
            } ,
                  new CarModel {
                    Color= "Blue",
                    Year = 2005,
                    Model = "Mersedes"
            },
                    new CarModel {
                    Color= "Yellow",
                    Year = 2010,
                    Model = "Mersedes"
            }
            });
        }
    }
}
