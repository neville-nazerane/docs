using Docs.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Docs.Website.Client.Documenations
{
    public partial class NetCore_Azure_Blob
    {

        CurrentDocument Document => new CurrentDocument
        {
            Package = new Package { }
        };

        class CurrentDocument
        {
            public Package Package { get; set; }

            public IEnumerable<TabItem> TabItems { get; set; }

            public string CurrentTab { get; set; }

            public bool HasTabs => TabItems?.Count() > 0;

        }


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
}
