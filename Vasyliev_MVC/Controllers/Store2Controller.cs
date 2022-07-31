using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Vasyliev_MVC.Models;

namespace Vasyliev_MVC.Controllers
{
    public class Store2Controller : Controller
    {
        private ILogger<Store2Controller> logger;
        public Store2Controller(ILogger<Store2Controller> logger)
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
    }
}
