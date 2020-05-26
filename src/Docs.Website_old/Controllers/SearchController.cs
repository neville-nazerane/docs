using Docs.Data;
using Docs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
            if (string.IsNullOrWhiteSpace(q)) return Redirect("~/");
            ViewBag.q = q;
            return View(new SearchResults
            {
                Packages = context.Packages.Where(p => p.Name.Contains(q) || p.Tags.Any(t => q.Contains(t.Tag.Title))).AsAsyncEnumerable(),
                //GitRepos = context.Packages.Where(p => p.GitRepo.Contains(q))
                //                             .GroupBy(p => p.GitRepo)
                //                             .ToDictionary(g => g.Key, g => g.AsEnumerable())
            });
        }
    }
}
