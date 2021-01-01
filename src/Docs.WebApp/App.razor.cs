using Docs.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp
{
    public partial class App
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        bool IsDocumentation
        {
            get
            {

                var path = NavigationManager.Uri?.Replace(NavigationManager.BaseUri, string.Empty);
                Console.WriteLine(path);
                if (string.IsNullOrEmpty(path))
                    return false;
                return path
                        .Split("/")
                        .FirstOrDefault()?
                        .Equals("documentation", StringComparison.OrdinalIgnoreCase)
                                == true;
            }
        }

        DocumentationMeta BuildDocMeta() => new DocumentationMeta();
    
    }
}
