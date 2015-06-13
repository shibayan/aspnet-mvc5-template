using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MvcApplication.Extensions
{
    public static class ValidationExtensions
    {
        public static MvcHtmlString ValidationSummaryView(this HtmlHelper htmlHelper, string partialViewName)
        {
            var modelState = htmlHelper.ViewData.ModelState;

            if (modelState.IsValid)
            {
                return MvcHtmlString.Empty;
            }

            return htmlHelper.Partial(partialViewName, modelState.SelectMany(x => x.Value.Errors));
        }
    }
}