using System;

namespace Docs.WebApp.Models.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class SummaryAttribute(string summary) : Attribute
    {
        
        public string Summary { get; set; } = summary;

    }
}
