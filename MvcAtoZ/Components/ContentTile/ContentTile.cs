using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace MvcAtoZ.Components.ContentTile
{
    [SitecoreType(TemplateId = "{743474BA-421C-4182-9F6A-033BAD4528A8}", AutoMap = true)]
    public class ContentTile
    {
        public virtual string Header { get; set; }
        public virtual string Body { get; set; }
        public virtual Link Link { get; set; }
    }
}
