using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.TagHelpers
{
    public class JsonTagHelper : CodeTagHelperBase
    {
        public JsonTagHelper() : base("json")
        {
        }
    }
}
