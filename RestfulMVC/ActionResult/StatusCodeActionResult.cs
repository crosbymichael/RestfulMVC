using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace RestfulMVC.ActionResult
{
    class StatusCodeActionResult : System.Web.Mvc.ActionResult
    {
        int statusCode;
        string statusDescription;

        public StatusCodeActionResult(int code)
        {
            statusCode = code;
        }

        public StatusCodeActionResult(int code, string description)
        {
            statusCode = code;
            statusDescription = description;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.StatusCode = statusCode;
            if (!string.IsNullOrEmpty(statusDescription))
            {
                response.StatusDescription = statusDescription;
            }
        }
    }
}
