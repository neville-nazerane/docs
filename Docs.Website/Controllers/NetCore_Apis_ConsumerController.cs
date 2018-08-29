using Docs.Website.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("NetCore.Apis.Consumer")]
    public class NetCore_Apis_ConsumerController : Controller
    {

        public IActionResult Index() => View();

    }
}
