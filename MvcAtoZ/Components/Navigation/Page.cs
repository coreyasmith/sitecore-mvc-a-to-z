using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MvcAtoZ.Components.Navigation
{
    [SitecoreType(TemplateId = Templates.Page.Id, AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.Template)]
    public class Page
    {
        public virtual string Title { get; set;}

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        public virtual string Url { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<Page> Children { get; set; }
    }
}
