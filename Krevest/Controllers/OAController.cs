using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Krevest.Controllers
{
    public class OAController : Controller
    {
        private readonly ILogger<ToDoController> _logger;

        public OAController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        public IActionResult OA()
        {
            return View();
        }

    }
}

