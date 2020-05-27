using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Client.Components
{
    public partial class CSharp
    {


        [Parameter]
        public RenderFragment ChildContent { get; set; }

    }
}
