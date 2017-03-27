using System.Collections.Generic;

namespace MvcAtoZ.Models
{
    public class NavigationBarViewModel
    {
        public IEnumerable<NavigationBarItem> Items { get; set; }

        public NavigationBarViewModel()
        {
            Items = new List<NavigationBarItem>();
        }
    }
}
