using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Client.Components
{
    public partial class CodeBlock
    {

        [Parameter]
        public string Language { get; set; }


        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
