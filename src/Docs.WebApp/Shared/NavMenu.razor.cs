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

        [Parameter]
        public DocumentationMeta Meta { get; set; }

        public ICollection<MenuItemData> MenuListing { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Meta is not null)
            {
                Meta.MenuUpdated = UpdateMenu;
                UpdateMenu();
            }
        }


        void UpdateMenu()
        {
            MenuListing = Meta.MenuItems;
            Console.WriteLine(99 + string.Join(",", MenuListing.Select(m => m.Text)));
            StateHasChanged();
        }

    }
}
