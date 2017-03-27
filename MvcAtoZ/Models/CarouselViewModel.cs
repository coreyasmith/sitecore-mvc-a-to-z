using System.Collections;
using System.Collections.Generic;

namespace MvcAtoZ.Models
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
