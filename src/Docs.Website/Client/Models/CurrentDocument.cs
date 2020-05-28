using Docs.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website.Client.Models
{
    class CurrentDocument
    {
        public Package Package { get; set; }

        public IEnumerable<TabItem> TabItems { get; set; }

        public string CurrentTab { get; set; }

        public bool HasTabs => TabItems?.Count() > 0;

    }
}
