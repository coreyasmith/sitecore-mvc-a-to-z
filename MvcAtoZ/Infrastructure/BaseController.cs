using System.Web.Routing;
using Glass.Mapper.Sc.Web.Mvc;

namespace MvcAtoZ.Infrastructure
{
    [JsonFilter]
    public class BaseController : GlassController
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ViewEngineCollection.Insert(0, new ComponentsFolderConventionViewEngine());
        }
    }
}
