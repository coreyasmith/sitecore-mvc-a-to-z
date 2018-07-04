using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace MvcAtoZ.Components.Card
{
    [SitecoreType(TemplateId = Templates.Card.Id, AutoMap = true)]
    public class Card
    {
        public virtual string Header { get; set; }
        public virtual string Body { get; set; }
        public virtual Link Link { get; set; }
    }
}
