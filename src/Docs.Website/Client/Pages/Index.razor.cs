using Docs.Core;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Docs.Website.Client.Pages
{
    public partial class Index
    {



        IEnumerable<Package> packages = null;


        protected override async Task OnInitializedAsync()
        {
            packages = await Http.GetFromJsonAsync<Package[]>("api/packages");
            await base.OnInitializedAsync();
        }

    }
}
