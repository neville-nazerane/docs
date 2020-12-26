using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Docs.WebApp.Models
{
    public class Package
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string GitRepo { get; set; }

        public bool IsDisplayed { get; set; }

        public bool HasDocumentation { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public string GitUrl => $"https://github.com/neville-nazerane/{GitRepo}";

        public string GitClone => $"git clone {GitUrl}.git";

        public string NugetUrl => $"https://www.nuget.org/packages/{Name}/";

    }
}
