using Docs.Data;
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

    [Documentation("NetCore.Azure.Blob", nameof(SetUp))]
    public class NetCore_Azure_BlobController : Controller
    {

        public NetCore_Azure_BlobController(CurrentDocument document)
        {
            document.TabItems = new TabItem[] {
                new TabItem(nameof(SetUp)),
                new TabItem(nameof(AccessBlobs)),
                new TabItem(nameof(TagHelpers)),
            };
        }

        public IActionResult SetUp() => View();

        public IActionResult AccessBlobs() => View();

        public IActionResult TagHelpers() => View();

    }
}
