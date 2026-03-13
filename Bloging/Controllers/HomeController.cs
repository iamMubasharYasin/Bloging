using Bloging.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bloging.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
