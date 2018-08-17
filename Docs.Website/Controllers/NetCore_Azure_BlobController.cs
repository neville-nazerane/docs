using Docs.Data;
using Docs.Website.Filters;
using Docs.Website.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("NetCore.Azure.Blob")]
    public class NetCore_Azure_BlobController : Controller
    {

        public IActionResult Index() => View();

    }
}
