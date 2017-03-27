using System.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Jumbotron
{
    public class JumbotronController : BaseController
    {
        public ActionResult Jumbotron()
        {
            var dataSource = GetDataSourceItem<Jumbotron>();
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
