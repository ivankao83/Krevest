using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Krevest.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ILogger<ToDoController> _logger;

        public ToDoController (ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        public IActionResult ToDo()
        {
            return View();
        }

    }
}

