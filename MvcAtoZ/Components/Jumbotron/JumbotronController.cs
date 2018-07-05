using System;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Jumbotron
{
    public class JumbotronController : BaseController
    {
        private readonly IMvcContext _mvcContext;

        public JumbotronController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext ?? throw new ArgumentNullException(nameof(mvcContext));
        }

        public ActionResult Jumbotron()
        {
            var dataSource = _mvcContext.GetDataSourceItem<Jumbotron>();
            var viewModel = new JumbotronViewModel
            {
                Headline = dataSource.Headline,
                Subtitle = dataSource.Subtitle,
                Body = dataSource.Body
            };
            return View(viewModel);
        }
    }
}
