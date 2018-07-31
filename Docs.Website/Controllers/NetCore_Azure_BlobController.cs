using Docs.Data;
using Docs.Website.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{

    [Route("NetCore.Azure.Blob/{[action]=index}")]
    public class NetCore_Azure_BlobController : Controller
    {

        public NetCore_Azure_BlobController(AppDbContext context, CurrentDocument document)
        {
            document.Package = context.Packages.SingleOrDefault(p => p.Name == "NetCore.Azure.Blob");
        }

        public IActionResult Index() => View();

    }
}
