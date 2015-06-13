using System;
using System.Web.Mvc;

using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route]
        [HttpPost]
        public ActionResult Index(SampleModel model)
        {
            return View();
        }

        [Route("Exception")]
        public ActionResult Exception()
        {
            throw new InvalidOperationException();
        }

        [Route("NotFound")]
        public ActionResult NotFound()
        {
            return HttpNotFound();
        }
    }
}