using Docs.WebApp.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Components
{
    public partial class DocLink
    {

        [Parameter]
        public string Document { get; set; }

        public bool HasDocumentationEnabled(string documentation)
            => PackageRepository.All
                                .SingleOrDefault(d => d.Name == documentation)?
                                .HasDocumentation == true;

    }
}
