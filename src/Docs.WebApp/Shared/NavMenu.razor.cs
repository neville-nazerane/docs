using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
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

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            //NavigationManager.LocationChanged += OnLocationChanges; ;
        }

        #region scrolling

        // source: https://stackoverflow.com/questions/55186784/scroll-to-specified-part-of-page-when-clicking-top-navigation-link-in-blazor

        private void OnLocationChanges(object sender, LocationChangedEventArgs e) => NavigateToElement();

        private void NavigateToElement()
        {
            var url = NavigationManager.Uri;
            var fragment = new Uri(url).Fragment;

            if (string.IsNullOrEmpty(fragment))
            {
                return;
            }

            var elementId = fragment.StartsWith("#") ? fragment.Substring(1) : fragment;

            if (string.IsNullOrEmpty(elementId))
            {
                return;
            }

            ScrollToElementId(elementId);
        }

        private bool ScrollToElementId(string elementId) 
            => JSRuntime.InvokeAsync<bool>("scrollToElementId", elementId).GetAwaiter().GetResult();
        
        #endregion

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
