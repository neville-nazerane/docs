using Docs.Website.Filters;
using Docs.Website.Models;
using Docs.Website.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("NetCore.Angular", nameof(Initialization))]
    public class NetCore_AngularController : Controller
    {

        public NetCore_AngularController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(Initialization)),
                new TabItem(nameof(Basics)),
                new TabItem(nameof(CommonDirectives)),
                new TabItem(nameof(AddingData)),
                new TabItem(nameof(Forms)),
                new TabItem(nameof(Swappable)),
            };
        }

        public IActionResult Initialization() => View();

        public IActionResult Basics() => View();

        public IActionResult CommonDirectives() => View();

        public IActionResult AddingData() => View();

        public IActionResult Forms() => View();

        public IActionResult Swappable() => View();


    }
}
