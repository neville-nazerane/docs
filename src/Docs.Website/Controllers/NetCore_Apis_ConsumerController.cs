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

    [Documentation("NetCore.Apis.Consumer", nameof(Consumer))]
    public class NetCore_Apis_ConsumerController : Controller
    {

        public NetCore_Apis_ConsumerController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(Consumer)),
                new TabItem(nameof(MakingCalls)),
                new TabItem(nameof(ConsumedResponse)),
            };
        }

        public IActionResult Consumer() => View();

        public IActionResult MakingCalls() => View();

        public IActionResult ConsumedResponse() => View();

    }
}
