using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using MvcAtoZ.Models;

namespace MvcAtoZ.Controllers
{
    public class NavigationController : GlassController
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
