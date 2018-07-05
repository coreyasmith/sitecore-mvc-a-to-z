using System;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Card
{
    public class CardController : BaseController
    {
        private readonly IMvcContext _mvcContext;

        public CardController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext ?? throw new ArgumentNullException(nameof(mvcContext));
        }

        public ActionResult Card()
        {
            var dataSource = _mvcContext.GetDataSourceItem<Card>();
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
