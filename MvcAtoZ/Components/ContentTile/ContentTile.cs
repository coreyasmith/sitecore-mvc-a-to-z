using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace MvcAtoZ.Components.ContentTile
{
    [SitecoreType(TemplateId = Templates.ContentTile.Id, AutoMap = true)]
    public class ContentTile
    {
        public virtual string Header { get; set; }
        public virtual string Body { get; set; }
        public virtual Link Link { get; set; }
    }
}
