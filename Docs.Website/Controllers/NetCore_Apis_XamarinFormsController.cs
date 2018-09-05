using Docs.Website.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("NetCore.Apis.XamarinForms")]
    public class NetCore_Apis_XamarinFormsController : Controller
    {

        public IActionResult Index() => View();

    }
}
