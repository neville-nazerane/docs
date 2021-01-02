using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Shared
{
    public partial class DocumentationLayout
    {

        readonly DocumentationMeta meta;

        public DocumentationLayout()
        {
            meta = new DocumentationMeta();
        }


    }
}
