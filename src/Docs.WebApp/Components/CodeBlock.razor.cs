using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Components
{
    public partial class CodeBlock
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string CodeClass { get; set; }

    }
}
