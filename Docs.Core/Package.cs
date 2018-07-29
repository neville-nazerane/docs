using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Docs.Core
{
    public class Package
    {

        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(600)]
        public string Description { get; set; }

        [MaxLength(100)]
        public string GitRepo { get; set; }

        [Required]
        public bool IsDisplayed { get; set; }

        [Required]
        public bool HasDocumentation { get; set; }

        [NotMapped]
        public string GitUrl => $"https://github.com/neville-nazerane/{GitRepo}";

        [NotMapped]
        public string GitClone => $"git clone {GitUrl}.git";

        [NotMapped]
        public string NugetUrl => $"https://www.nuget.org/packages/{Name}/";

    }
}
