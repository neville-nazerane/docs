using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Docs.Website.Models;
using Docs.Data;

namespace Docs.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context) => this.context = context;

        public string Test() => "test page to ensure website loads";

        public string Sample() => "hello CI CD";

        public IActionResult Index() 
                => View(from p in context.Packages
                        where p.IsDisplayed
                        orderby p.Name
                        select p);

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
