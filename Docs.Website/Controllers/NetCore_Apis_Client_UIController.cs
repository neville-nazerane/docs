using Docs.Website.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("NetCore.Apis.Client.UI")]
    public class NetCore_Apis_Client_UIController : Controller
    {

        public IActionResult Index() => View();

    }
}
