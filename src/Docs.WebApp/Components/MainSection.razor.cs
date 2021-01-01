using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Components
{
    public partial class MainSection
    {

        [Parameter]
        public string MenuText { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment Description { get; set; }
        
        [Parameter]
        public RenderFragment Content { get; set; }

        [CascadingParameter(Name = "metaData")]
        public DocumentationMeta DocumentationMeta { get; set; }

        MenuItemData currentItem;

        public MainSection()
        {
            currentItem = new MenuItemData();
        }

        protected override void OnParametersSet()
        {
            if (DocumentationMeta is not null && MenuText is not null)
            {
                SetMenuText();
            }
            base.OnParametersSet();
        }

        [CascadingParameter(Name = "menu")]
        public ICollection<MenuItemData> MenuListing { get; set; }

        void SetMenuText()
        {
            currentItem.Text = MenuText;
            //MenuListing.Add(currentItem);
            DocumentationMeta.MenuItems.Add(currentItem);
            DocumentationMeta.MenuUpdated?.Invoke();
        }
    }
}
