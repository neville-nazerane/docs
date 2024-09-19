using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    public static class NavigationExtensions
    {

        public static string GetPath(this NavigationManager manager)
            => manager.Uri?.Replace(manager.BaseUri, string.Empty)
                      .Split("#").First();

        public static string GetQueryParam(this NavigationManager manager, string name)
            => manager.Uri.GetQueryParam(name);

        public static string GetQueryParam(this LocationChangedEventArgs locationChanged, string name)
            => locationChanged.Location.GetQueryParam(name);

        public static void SetQueryParameter(this NavigationManager manager, string key, string value)
        {
            var url = manager.GetUriWithQueryParameter(key, value);
            manager.NavigateTo(url, false, true);
        }

        static string GetQueryParam(this string uri, string name)
        {
            var uriBuilder = new UriBuilder(uri);
            var q = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);
            return q[name];
        }

    }
}
