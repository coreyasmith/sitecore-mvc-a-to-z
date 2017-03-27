using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Views.Navigation
{
    public class NavigationController : BaseController
    {
        public ActionResult NavigationBar()
        {
            var rootItem = SitecoreContext.GetHomeItem<Page>();
            var navItems = new List<Page> { rootItem };
            navItems.AddRange(rootItem.Children);

            var viewModel = new NavigationBarViewModel
            {
                Items = navItems.Select(i => new NavigationBarItem
                {
                    Url = i.Url,
                    UrlLabel = i.Title
                })
            };

            return View(viewModel);
        }
    }
}
