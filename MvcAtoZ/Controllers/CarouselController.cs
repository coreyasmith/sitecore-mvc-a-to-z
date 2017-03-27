using System.Linq;
using System.Web.Mvc;
using MvcAtoZ.Infrastructure;
using MvcAtoZ.Models;

namespace MvcAtoZ.Controllers
{
    public class CarouselController : BaseController
    {
        public ActionResult Carousel()
        {
            var dataSource = GetDataSourceItem<Carousel>();

            var viewModel = new CarouselViewModel
            {
                Title = dataSource.Title
            };
            for (var i = 0; i < dataSource.Items.Count(); i++)
            {
                var item = dataSource.Items.ElementAt(i);
                viewModel.Items.Add(new CarouselItemViewModel
                {
                    ImageUrl = item.Image.Src,
                    ImageAlt = item.Image.Alt,
                    Caption = item.Caption,
                    Class = i == 0 ? "active" : string.Empty
                });
            }

            return View(viewModel);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
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

        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var contentType = filterContext.HttpContext.Response.ContentType;
            filterContext.Controller.ViewBag.ContentType = contentType;
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var contentType = filterContext.Controller.ViewBag.ContentType;
            filterContext.HttpContext.Response.ContentType = contentType;
        }
    }
}
