using SecurityTamperProofQueryString.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

using System.Web.Mvc;

namespace SecurityTamperProofQueryString.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class TamperProofQueryStringAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (TamperProofComputeHash.IsValidQueryString(filterContext.HttpContext.Request.QueryString))
                base.OnActionExecuted(filterContext);
        }
    }
}
