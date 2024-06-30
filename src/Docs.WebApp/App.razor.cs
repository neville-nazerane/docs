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
        private NavigationManager _navigationManager;

        [Inject]
        public NavigationManager NavigationManager
        {
            get => _navigationManager; 
            set
            {
                if (_navigationManager is not null)
                    value.LocationChanged -= LocationChanged;
                _navigationManager = value;
                value.LocationChanged += LocationChanged;
            }
        }

        private async void LocationChanged(object sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
        {
            await JSRuntime.InvokeVoidAsync("startup");
        }

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
