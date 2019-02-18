using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BonAppPizzaTeste_Ooui.Models;
using BonAppPizzaTeste_Ooui.Pages;

using Ooui.AspNetCore;
using Xamarin.Forms;

namespace BonAppPizzaTeste_Ooui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new LoginPage();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Hello from XAML!");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
