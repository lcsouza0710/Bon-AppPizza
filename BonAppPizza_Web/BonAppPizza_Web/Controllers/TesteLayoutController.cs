using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BonAppPizza_Web.Controllers
{
    public class TesteLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}