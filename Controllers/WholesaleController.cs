using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Krevest.Controllers
{
    public class WholesaleController : Controller
    {
        private readonly ILogger<ToDoController> _logger;

        public WholesaleController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Wholesale()
        {
            return View();
        }

    }
}

