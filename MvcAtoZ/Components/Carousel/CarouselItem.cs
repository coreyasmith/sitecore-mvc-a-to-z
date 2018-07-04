using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace MvcAtoZ.Components.Carousel
{
    [SitecoreType(TemplateId = Templates.CarouselItem.Id, AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.Template)]
    public class CarouselItem
    {
        public virtual Image Image { get; set; }
        public virtual string Caption { get; set; }
    }
}
