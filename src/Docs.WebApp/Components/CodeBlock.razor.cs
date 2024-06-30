using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Components
{
    public partial class CodeBlock
    {

        [Inject]
        public IJSRuntime JS { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string CodeClass { get; set; }

        string id;

        protected override async Task OnParametersSetAsync()
        {
            if (id is null && ChildContent is not null)
            {
                id = Guid.NewGuid().ToString();
                await JS.InvokeVoidAsync("window.fixCodePadding", id);
            }
        }

    }
}
