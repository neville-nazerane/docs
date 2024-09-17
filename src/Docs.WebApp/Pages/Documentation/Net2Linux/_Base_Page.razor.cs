using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;

namespace Docs.WebApp.Pages.Documentation.Net2Linux
{
    public partial class _Base_Page
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        DotNetProjectType? projectType;

        protected override void OnInitialized()
        {
            RefreshProjectType();

            base.OnInitialized();
        }

        void SelectType(DotNetProjectType selection)
        {
            Console.WriteLine(selection);
            var url = NavigationManager.GetUriWithQueryParameter("project", selection.ToString());
            Console.WriteLine(url);
            NavigationManager.NavigateTo(url, false);
            RefreshProjectType();
            StateHasChanged();

        }

        void RefreshProjectType()
        {
            string project = NavigationManager.GetQueryParm("project");
            if (Enum.TryParse<DotNetProjectType>(project, out var res))
            {
                projectType = res;
            }
            else
                Console.WriteLine("Failed to find project type " + project);
        }
    }
}
