using System.Linq;
using System.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Carousel
{
    public class CarouselController : BaseController
    {
        public ActionResult Carousel()
        {
            var dataSource = GetDataSourceItem<Carousel>();

            var viewModel = new CarouselViewModel
            {
                Title = dataSource.Title
            };
            for (var i = 0; i < dataSource.Items.Count(); i++)
            {
                var item = dataSource.Items.ElementAt(i);
                viewModel.Items.Add(new CarouselItemViewModel
                {
                    ImageUrl = item.Image.Src,
                    ImageAlt = item.Image.Alt,
                    Caption = item.Caption,
                    Class = i == 0 ? "active" : string.Empty
                });
            }

            return View(viewModel);
        }
    }
}
