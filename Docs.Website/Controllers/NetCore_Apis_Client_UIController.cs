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

    [Documentation("NetCore.Apis.Client.UI", nameof(Intro))]
    public class NetCore_Apis_Client_UIController : Controller
    {

        public NetCore_Apis_Client_UIController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(Intro)),
                new TabItem(nameof(ModelHandler)),
                new TabItem(nameof(Mapping)),
                //new TabItem(nameof(Submit)),
            };
        }

        public IActionResult Intro() => View();

        public IActionResult ModelHandler() => View();

        public IActionResult Mapping() => View();

        public IActionResult Submit() => View();

    }
}
