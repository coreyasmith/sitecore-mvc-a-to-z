using Glass.Mapper.Sc.Configuration.Attributes;

namespace MvcAtoZ.Components.Jumbotron
{
    [SitecoreType(TemplateId = Templates.Jumbotron.Id, AutoMap = true)]
    public class Jumbotron
    {
        public virtual string Headline { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string Body { get; set; }
    }
}
