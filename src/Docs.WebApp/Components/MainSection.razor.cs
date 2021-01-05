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
        public string Id { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public RenderFragment Description { get; set; }
        
        [Parameter]
        public RenderFragment Content { get; set; }

        [CascadingParameter(Name = "metaData")]
        public DocumentationMeta DocumentationMeta { get; set; }

        readonly MenuItemData currentItem;

        public MainSection()
        {
            currentItem = new MenuItemData();
        }

        protected override void OnParametersSet()
        {
            if (DocumentationMeta is not null 
                && Title is not null
                && Id is not null
                && Icon is not null)
            {
                SetMenuText();
            }
            base.OnParametersSet();
        }

        void SetMenuText()
        {
            if (DocumentationMeta.MenuItems.Any(i => i.Id == Id)) return;

            currentItem.Id = Id;
            currentItem.Text = Title;
            currentItem.Icon = Icon;

            DocumentationMeta.MenuItems.Add(currentItem);
            DocumentationMeta.MenuUpdated?.Invoke();
        }

    }
}
