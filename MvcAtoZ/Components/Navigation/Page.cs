using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MvcAtoZ.Components.Navigation
{
    [SitecoreType(TemplateId = "{E8134447-5A71-4DE2-BE59-2869F6CB9A6C}", AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.Template)]
    public class Page
    {
        public virtual string Title { get; set;}

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        public virtual string Url { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<Page> Children { get; set; }
    }
}
