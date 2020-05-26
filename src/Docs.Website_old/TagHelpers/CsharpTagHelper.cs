﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.TagHelpers
{
    public class CsharpTagHelper : CodeTagHelperBase
    {

        public CsharpTagHelper() : base("csharp")
        {
        }

    }
}
