using Docs.Data;
using Docs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext context;

        public SearchController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(string q)
        {
            ViewBag.q = q;

            return View(new SearchResults
            {
                Packages = from pt in context.PackageTags
                           where pt.Package.Name.Contains(q, StringComparison.InvariantCultureIgnoreCase) 
                                            || q.Contains(pt.Tag.Title, StringComparison.InvariantCultureIgnoreCase)
                           select pt.Package,
                GitRepos = context.Packages.Where(p => p.GitRepo.Contains(q))
                                             .GroupBy(p => p.GitRepo)
                                             .ToDictionary(g => g.Key, g => g.AsEnumerable())
            });
        }
    }
}
