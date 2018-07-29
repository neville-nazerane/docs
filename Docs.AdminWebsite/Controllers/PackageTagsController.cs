using Docs.Core;
using Docs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.AdminWebsite.Controllers
{
    public class PackageTagsController : Controller
    {
        private readonly AppDbContext context;

        public PackageTagsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet, Route("package/tags/{id}")]
        public IActionResult Index(int id)
        {
            ViewBag.title = context.Packages.Find(id).Name;
            ViewBag.id = id;
            ViewBag.TagItems = context.Tags.Select(t => new SelectListItem(t.Title, t.Id.ToString()));
            return View(from pt in context.PackageTags
                        where pt.PackageId == id
                        select pt.Tag);
        }

        [HttpPost]
        public IActionResult Add(PackageTag tag)
        {
            context.Add(tag);
            context.SaveChanges();
            return RedirectToAction(nameof(Index), new { id = tag.PackageId });
        }

        [HttpGet]
        public IActionResult Delete(PackageTag tag)
        {
            var data = context.PackageTags.SingleOrDefault(pt => pt.PackageId == tag.PackageId && pt.TagId == tag.TagId);
            context.Remove(data);
            context.SaveChanges();
            return RedirectToAction(nameof(Index), new { id = tag.PackageId });
        }

    }
}
