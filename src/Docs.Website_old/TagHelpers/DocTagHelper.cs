using Docs.Website.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.TagHelpers
{

    public class DocTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;
        private readonly ValidDocs validDocs;

        [ViewContext, HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public string Link { get; set; }

        public DocTagHelper(IUrlHelperFactory urlHelperFactory, ValidDocs validDocs)
        {
            this.urlHelperFactory = urlHelperFactory;
            this.validDocs = validDocs;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            if (Link != null)
            {
                if (validDocs.IsValid(Link))
                {
                    output.TagName = "a";
                    output.Attributes.SetAttribute("href",
                        urlHelperFactory.GetUrlHelper(ViewContext).Content("~/" + Link));
                }
                else
                {
                    output.TagName = "code";
                    output.Attributes.SetAttribute("title", 
                                        "Documentation not available");
                }

                output.TagMode = TagMode.StartTagAndEndTag;
                output.Content.SetContent(Link);
            }

        }

    }
}
