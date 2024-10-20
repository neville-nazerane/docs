using Microsoft.AspNetCore.Components;

namespace Docs.WebApp.Components
{
    public partial class LeftNav
    {

        [Parameter]
        public RenderFragment ChildContent { get; set; }

    }
}
