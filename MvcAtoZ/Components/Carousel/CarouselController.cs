using System;
using System.Linq;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using MvcAtoZ.Infrastructure;

namespace MvcAtoZ.Components.Carousel
{
    public class CarouselController : BaseController
    {
        private readonly IMvcContext _mvcContext;

        public CarouselController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext ?? throw new ArgumentNullException(nameof(mvcContext));
        }

        public ActionResult Carousel()
        {
            var dataSource = _mvcContext.GetDataSourceItem<Carousel>();

            var viewModel = new CarouselViewModel
            {
                Title = dataSource.Title
            };
            for (var i = 0; i < dataSource.Items.Count(); i++)
            {
                var item = dataSource.Items.ElementAt(i);
                viewModel.Items.Add(new CarouselItemViewModel
                {
                    Index = i,
                    ImageUrl = item.Image.Src,
                    ImageAlt = item.Image.Alt,
                    ShowCaption = !string.IsNullOrEmpty(item.Caption),
                    Caption = item.Caption,
                    Class = i == 0 ? "active" : string.Empty
                });
            }

            return View(viewModel);
        }
    }
}
