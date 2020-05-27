using Docs.Website.Server.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Docs.Website.Server
{
    public static class EndpointExtensions
    {

        public static void MapAllMyEndpoints(this IEndpointRouteBuilder endpoints)
        {

            endpoints.MapGet("/api/packages", context =>
                context.Response.WriteAsync(
                        JsonSerializer.Serialize(context.RequestServices.GetService<DocumentationService>().GetPackagesAsync())));

        }

    }
}
