using System.Collections.Generic;

namespace MvcAtoZ.Components.Carousel
{
    public class CarouselViewModel
    {
        public string Title { get; set; }
        public IList<CarouselItemViewModel> Items { get; set; }

        public CarouselViewModel()
        {
            Items = new List<CarouselItemViewModel>();
        }
    }
}
