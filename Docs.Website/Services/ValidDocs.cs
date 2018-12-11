using Docs.Core;
using Docs.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Services
{
    public class ValidDocs
    {
        private readonly Contents contents;

        public ValidDocs(AppDbContext context, Contents contents)
        {
            if (contents.Packages == null)
                contents.Packages = context.Packages.AsNoTracking()
                    .Where(p => p.IsDisplayed && p.HasDocumentation).ToList();
            this.contents = contents;
        }

        public bool IsValid(string packageName) => contents.Packages.Any(p => p.Name == packageName);

    }
}
