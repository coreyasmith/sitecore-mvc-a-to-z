using System.Web.Mvc;
using MvcAtoZ.Infrastructure;
using MvcAtoZ.Models;

namespace MvcAtoZ.Controllers
{
    public class ContentTileController : BaseController
    {
        public ActionResult ContentTile()
        {
            var dataSource = GetDataSourceItem<ContentTile>();
            var viewModel = new ContentTileViewModel
            {
                Header = dataSource.Header,
                Body = dataSource.Body,
                Url = dataSource.Link.Url,
                UrlLabel = dataSource.Link.Text
            };
            return View(viewModel);
        }
    }
}
