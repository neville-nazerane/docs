using Docs.Website.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Middlewares
{
    public class RedirectMiddleware
    {

        static Dictionary<string, string> _Redirects;
        public static Dictionary<string, string> Redirects 
                => _Redirects ?? (_Redirects = new Dictionary<string, string>());

        private readonly RequestDelegate next;

        public RedirectMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (Redirects.ContainsKey(httpContext.Request.Path))
                httpContext.Response.Redirect(Redirects[httpContext.Request.Path]);
            else await next(httpContext);
        }

    }
}
