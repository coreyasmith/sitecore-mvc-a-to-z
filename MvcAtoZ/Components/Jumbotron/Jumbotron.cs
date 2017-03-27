using Glass.Mapper.Sc.Configuration.Attributes;

namespace MvcAtoZ.Components.Jumbotron
{
    [SitecoreType(TemplateId = "{5F67975A-BA5B-4A4B-AFA1-006E43B6AD87}", AutoMap = true)]
    public class Jumbotron
    {
        public virtual string Headline { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string Body { get; set; }
    }
}
