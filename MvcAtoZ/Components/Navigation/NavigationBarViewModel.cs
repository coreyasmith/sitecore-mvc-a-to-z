using System.Collections.Generic;

namespace MvcAtoZ.Components.Navigation
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
