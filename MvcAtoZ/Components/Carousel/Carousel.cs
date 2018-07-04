using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MvcAtoZ.Components.Carousel
{
    [SitecoreType(TemplateId = Templates.Carousel.Id, AutoMap = true)]
    public class Carousel
    {
        public virtual string Title { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<CarouselItem> Items { get; set; }
    }
}
