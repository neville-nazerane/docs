using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.TagHelpers
{
    public class JsonTagHelper : TagHelper
    {


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);
            var c = await output.GetChildContentAsync();
            string content = c.GetContent().Trim();
            output.TagName = "pre";
            output.Content.SetHtmlContent($"<code class='csharp'>{content}</code>");
        }

    } 
}
