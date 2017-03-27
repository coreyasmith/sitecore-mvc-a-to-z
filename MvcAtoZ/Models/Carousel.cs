using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MvcAtoZ.Models
{
    [SitecoreType(TemplateId = "{4C0E48C4-1DB5-41F0-9167-3BAB61F52DC2}", AutoMap = true)]
    public class Carousel
    {
        public virtual string Title { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<CarouselItem> Items { get; set; }
    }
}
