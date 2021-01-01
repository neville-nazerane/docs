using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Shared
{
    public partial class DocumentationLayout
    {

        DocumentationMeta meta;

        ICollection<MenuItemData> menuListing;

        public EventCallback<MenuItemData> MenuItemAdded { get; set; }

        public DocumentationLayout()
        {
            menuListing = new List<MenuItemData>();
            meta = new DocumentationMeta
            {
                //MenuUpdated = UpdateMenu
            };
            //UpdateMenu();
        }

        int count;

        void UpdateMenu()
        {
            menuListing = meta.MenuItems;
            Console.WriteLine(count++ + string.Join(",", menuListing.Select(m => m.Text)));
            //StateHasChanged();
        }

    }
}
