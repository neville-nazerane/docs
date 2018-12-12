using Docs.Website.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("AspNetCore.KeyVault")]
    public class AspNetCore_KeyVaultController : Controller
    {

        public IActionResult Index() => View();

    }
}
