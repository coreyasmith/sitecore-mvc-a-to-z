using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Navigation
{
    public class NavigationController : BaseController
    {
        private readonly IMvcContext _mvcContext;

        public NavigationController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext ?? throw new ArgumentNullException(nameof(mvcContext));
        }

        public ActionResult NavigationBar()
        {
            var rootItem = _mvcContext.GetHomeItem<Page>();
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
