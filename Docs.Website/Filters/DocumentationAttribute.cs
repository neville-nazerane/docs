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
    public class DocumentationAttribute : Attribute, IResourceFilter
    {

        public string NugetName { get; }

        public DocumentationAttribute(string PackageName)
        {
            NugetName = PackageName;
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var document = context.HttpContext.RequestServices.GetService<CurrentDocument>();

            var package = document.AssignPackage(NugetName);
            if (package == null) context.Result = new NotFoundResult();
        }
    }
}
