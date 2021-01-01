using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Models
{
    public class DocumentationMeta
    {
        public ICollection<MenuItemData> MenuItems { get; set; }

        public Action MenuUpdated { get; set; }

        public DocumentationMeta()
        {
            MenuItems = new List<MenuItemData>();
        }

    }
}
