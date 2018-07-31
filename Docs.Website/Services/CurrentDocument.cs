using Docs.Core;
using Docs.Data;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Services
{
    public class CurrentDocument
    {
        private readonly AppDbContext context;
        private readonly IHostingEnvironment env;

        public Package Package { get; set; }

        public CurrentDocument(AppDbContext context, IHostingEnvironment env)
        {
            this.context = context;
            this.env = env;
        }

        public Package AssignPackage(string name)
            => Package = context.Packages.SingleOrDefault(p => p.Name == name && (env.IsDevelopment() || p.HasDocumentation));

    }
}
