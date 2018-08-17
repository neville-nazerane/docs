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

    [Documentation("NetCore.ModelValidation.Core")]
    public class NetCore_ModelValidation_CoreController : Controller
    {

        public NetCore_ModelValidation_CoreController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(Introduction))
            };
        }

        [Route("NetCore.ModelValidation.Core")]
        public IActionResult Index() => RedirectToAction();

        public IActionResult Introduction() => View();

    }
}
