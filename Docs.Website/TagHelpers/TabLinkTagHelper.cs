using Docs.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.TagHelpers
{

    public class TabLinkTagHelper : AnchorTagHelper
    {
        private readonly CurrentDocument currentDocument;

        public string Current { get; set; }

        public TabLinkTagHelper(IHtmlGenerator generator, CurrentDocument currentDocument) : base(generator)
        {
            this.currentDocument = currentDocument;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            string tabName = currentDocument?.CurrentTab ??
                ViewContext.RouteData.Values["Action"].ToString();
            string current = Current ?? Action;
            if (string.Equals(tabName, current, StringComparison.CurrentCultureIgnoreCase))
            {
                string classValue = "active";
                if (output.Attributes
                                .TryGetAttribute("class", out var classAttr))
                {
                    classValue = $"{classAttr.Value} {classValue}";
                }
                output.Attributes.SetAttribute("class", classValue);
            }

            base.Process(context, output);
        }

    }
}
