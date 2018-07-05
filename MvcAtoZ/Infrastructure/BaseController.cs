using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAtoZ.Infrastructure
{
    [JsonFilter]
    public class BaseController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ViewEngineCollection.Insert(0, new ComponentsFolderConventionViewEngine());
        }
    }
}
