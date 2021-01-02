using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp
{
    public partial class App
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        bool IsDocumentation
        {
            get
            {

                var path = NavigationManager.Uri?.Replace(NavigationManager.BaseUri, string.Empty);
                if (string.IsNullOrEmpty(path))
                    return false;
                return path
                        .Split("/")
                        .FirstOrDefault()?
                        .Equals("documentation", StringComparison.OrdinalIgnoreCase)
                                == true;
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            await JSRuntime.InvokeVoidAsync("rendered", firstRender);
        }

    }
}
