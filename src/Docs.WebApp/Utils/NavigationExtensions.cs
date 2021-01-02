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

    }
}
