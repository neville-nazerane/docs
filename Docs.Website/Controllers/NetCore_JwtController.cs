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

    [Documentation("NetCore.Jwt", nameof(SetUp))]
    public class NetCore_JwtController : Controller
    {

        public NetCore_JwtController(CurrentDocument current)
        {
            current.TabItems = new TabItem[] {
                new TabItem(nameof(SetUp)),
                new TabItem(nameof(FetchingTokens)),
            };
        }

        public IActionResult SetUp() => View();

        public IActionResult FetchingTokens() => View();

    }
}
