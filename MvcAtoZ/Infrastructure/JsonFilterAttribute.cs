using System.Web.Mvc;

namespace MvcAtoZ.Infrastructure
{
    public class JsonFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Request.QueryString["json"] == null) return;

            // Cast to ViewResultBase to support both ViewResult and PartialViewResult
            var viewResult = filterContext.Result as ViewResultBase;
            if (viewResult == null) return;

            filterContext.Result = new JsonResult
            {
                Data = viewResult.Model,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var contentType = filterContext.HttpContext.Response.ContentType;
            filterContext.Controller.ViewBag.ContentType = contentType;
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var contentType = filterContext.Controller.ViewBag.ContentType;
            filterContext.HttpContext.Response.ContentType = contentType;
        }
    }
}