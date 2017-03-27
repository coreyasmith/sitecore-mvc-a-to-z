using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using MvcAtoZ.Models;

namespace MvcAtoZ.Controllers
{
    public class JumbotronController : GlassController
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
