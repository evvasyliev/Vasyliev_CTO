using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Vasyliev_MVC.Models;

namespace Vasyliev_MVC.Controllers
{
    public class CounterController : Controller
    {
        private ILogger<CounterController> logger;
        public CounterController(ILogger<CounterController> logger)
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
