using System.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Card
{
    public class CardController : BaseController
    {
        public ActionResult Card()
        {
            var dataSource = GetDataSourceItem<Card>();
            var viewModel = new CardViewModel
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
