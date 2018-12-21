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

    [Documentation("MySql.Simple", nameof(Connecting))]
    public class MySql_SimpleController : Controller
    {

        public MySql_SimpleController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(Connecting)),
                new TabItem(nameof(Quering)),
                new TabItem(nameof(CodeFriendly)),
            };
        }

        public IActionResult Connecting() => View();

        public IActionResult Quering() => View();

        public IActionResult CodeFriendly() => View();

    }
}
