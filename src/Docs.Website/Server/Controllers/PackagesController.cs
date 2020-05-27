using Docs.Core;
using Docs.Website.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PackagesController : Controller
    {
        private readonly DocumentationService _documentationService;

        public PackagesController(DocumentationService documentationService)
        {
            _documentationService = documentationService;
        }

        [HttpGet]
        public async Task<IEnumerable<Package>> Get() => await _documentationService.GetPackagesAsync();
    
    }
}
