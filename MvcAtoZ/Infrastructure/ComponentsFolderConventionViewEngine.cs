using System.Web.Mvc;

namespace MvcAtoZ.Infrastructure
{
    public class ComponentsFolderConventionViewEngine : RazorViewEngine
    {
        public ComponentsFolderConventionViewEngine()
        {
            var locationFormats = new[]
            {
                "~/Components/{1}/{0}.cshtml",
                "~/Components/Shared/{0}.cshtml"
            };
            PartialViewLocationFormats = locationFormats;
            ViewLocationFormats = locationFormats;

            var areaLocationFormats = new[]
            {
                "~/Areas/{2}/Components/{1}/{0}.cshtml",
                "~/Areas/{2}/Components/Shared/{0}.cshtml"
            };
            AreaPartialViewLocationFormats = areaLocationFormats;
            AreaViewLocationFormats = areaLocationFormats;
        }
    }
}
