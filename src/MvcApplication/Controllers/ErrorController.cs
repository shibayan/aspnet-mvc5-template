using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    [Route("{action=Index}"), RoutePrefix("Error")]
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            Response.StatusCode = 500;

            return View();
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = 404;

            return View();
        }
    }
}