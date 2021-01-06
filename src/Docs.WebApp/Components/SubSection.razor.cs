using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Components
{
    public partial class SubSection
    {

        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string Heading { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }


        [CascadingParameter(Name = "metaData")]
        public DocumentationMeta DocumentationMeta { get; set; }

        [CascadingParameter(Name = "parentSection")]
        public MenuItemData ParentItem { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            SetText();
        }

        void SetText()
        {
            if (ParentItem.SubMenuItems.Any(t => t.Id == Id)) return;

            ParentItem.SubMenuItems.Add(new SubMenuItemsData 
            { 
                Id = Id,
                Text = Heading
            });
            DocumentationMeta.MenuUpdated?.Invoke();
        }

    }
}
