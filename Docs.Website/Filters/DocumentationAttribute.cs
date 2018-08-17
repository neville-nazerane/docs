using Docs.Data;
using Docs.Website.Middlewares;
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
        public string DefaultAction { get; }

        public bool IsReusable => true;

        public DocumentationAttribute(string packageName) : base(packageName)
        {
            PackageName = packageName;
        }

        public DocumentationAttribute(string packageName, string defaultAction) : base(packageName + "/[action]")
        {
            PackageName = packageName;
            RedirectMiddleware.Redirects["/" + packageName] = $"/{packageName}/{defaultAction}";
            DefaultAction = defaultAction;
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
