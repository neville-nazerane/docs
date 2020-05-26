using Docs.Core;
using Docs.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Server.Services
{
    public class DocumentationService
    {
        private readonly AppDbContext _context;

        public DocumentationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Package>> GetPackagesAsync()
        {
            return await _context.Packages
                                .Where(p => p.HasDocumentation && p.IsDisplayed)
                                .ToArrayAsync();
        }

    }
}
