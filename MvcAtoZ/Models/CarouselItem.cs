using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace MvcAtoZ.Models
{
    [SitecoreType(TemplateId = "{836206BA-BAC2-467E-8E1B-C8A6BCBF157F}", AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.Template)]
    public class CarouselItem
    {
        public virtual Image Image { get; set; }
        public virtual string Caption { get; set; }
    }
}
