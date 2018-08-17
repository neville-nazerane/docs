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

    [Documentation("NetCore.ModelValidation.Core", nameof(Introduction))]
    public class NetCore_ModelValidation_CoreController : Controller
    {

        public NetCore_ModelValidation_CoreController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(Introduction)),
                new TabItem(nameof(Setup)),
                new TabItem(nameof(SimpleError)),
            };
        }

        public IActionResult Introduction() => View();

        public IActionResult Setup() => View();

        public IActionResult SimpleError() => View();

    }
}
