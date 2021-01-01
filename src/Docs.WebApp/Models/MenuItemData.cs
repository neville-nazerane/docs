using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Models
{
    public class MenuItemData
    {

        public string Text { get; set; }

        public ICollection<SubMenuItemsData> SubMenuItems { get; set; }

        public MenuItemData()
        {
            SubMenuItems = new List<SubMenuItemsData>();
        }

    }
}
