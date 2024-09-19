using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;

namespace Docs.WebApp.Pages.Documentation.Net2Linux
{
    public partial class _Base_Page : IDisposable
    {

        private const string PROJECT_KEY = "project";

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        DotNetProjectType? projectType;

        protected override void OnInitialized()
        {
            RefreshProjectType(NavigationManager.GetQueryParam(PROJECT_KEY));
            base.OnInitialized();
            NavigationManager.LocationChanged += LocationChanged;
        }

        private void LocationChanged(object sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
        {
            RefreshProjectType(e.GetQueryParam(PROJECT_KEY));
        }

        void SelectType(DotNetProjectType selection)
        {
            var url = NavigationManager.GetUriWithQueryParameter(PROJECT_KEY, selection.ToString());
            NavigationManager.NavigateTo(url, false, true);
        }

        void RefreshProjectType(string project)
        {
            if (project is null) return;
            if (Enum.TryParse<DotNetProjectType>(project, out var res))
            {
                projectType = res;
                StateHasChanged();
            }
            else
                Console.WriteLine("Failed to find project type " + project);
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= LocationChanged;
        }
    }
}
