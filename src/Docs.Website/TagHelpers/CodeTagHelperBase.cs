using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.TagHelpers
{
    public abstract class CodeTagHelperBase : TagHelper
    {
        private readonly string lang;

        public CodeTagHelperBase(string lang)
        {
            this.lang = lang;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);
            var c = await output.GetChildContentAsync();
            string content = c.GetContent().Trim();
            output.TagName = "pre";
            output.Content.SetHtmlContent($"<code class='{lang}'>{content}</code>");
        }

    }
}
