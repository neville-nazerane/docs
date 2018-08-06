using Docs.Data;
using Docs.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Filters
{
    public class DocumentationAttribute : RouteAttribute, IResourceFilter
    {

        public string PackageName { get; }

        public DocumentationAttribute(string packageName) : base(packageName + "/{[action]=index}")
        {
            PackageName = packageName;
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var document = context.HttpContext.RequestServices.GetService<CurrentDocument>();

            var package = document.AssignPackage(PackageName);
            if (package == null) context.Result = new NotFoundResult();
        }

        public void OnResourceExecuted(ResourceExecutedContext context) { }
    }
}
