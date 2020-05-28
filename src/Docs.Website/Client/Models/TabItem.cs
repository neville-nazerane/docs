using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Docs.Website.Client.Models
{
    public class TabItem
    {

        public TabItem()
        {

        }

        public TabItem(string all)
        {
            All = all;
        }

        public string Title { get; set; }

        public string Action { get; set; }

        public string All
        {
            set
            {
                Action = value;
                Title = Regex.Replace(value, "([a-z])([A-Z])", "$1 $2");
            }
        }

    }
}
