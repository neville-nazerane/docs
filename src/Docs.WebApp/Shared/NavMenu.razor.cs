using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Shared
{
    public partial class NavMenu
    {

        [CascadingParameter(Name = "metaData")]
        public DocumentationMeta Meta { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Meta is not null)
            {
                Meta.MenuUpdated = UpdateMenu;
                UpdateMenu();
            }
        }

        string BuildLink(string id) => $"{NavigationManager.GetPath()}#{id}";

        void UpdateMenu()
        {
            StateHasChanged();
        }

    }
}
