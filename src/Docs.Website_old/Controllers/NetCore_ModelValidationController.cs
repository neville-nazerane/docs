using Docs.Website.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Documentation("NetCore.ModelValidation")]
    public class NetCore_ModelValidationController : Controller
    {

        public IActionResult Index() => View();

    }
}
