using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using RestfulMVC.ActionResult;

namespace RestfulMVC
{
    static class RestfulActionResultFactory
    {
        public static System.Web.Mvc.ActionResult Result(object data, ContentTypes contentType, HttpStatusCode statusCode)
        {
            switch (contentType)
            { 
                case ContentTypes.Html:
                case ContentTypes.Text:
                case ContentTypes.FormEncoded:
                    return new StringActionResult(data, contentType, statusCode);
                case ContentTypes.Binary:
                    return new BinaryActionResult(data, contentType, statusCode);
                case ContentTypes.Xml:
                    return new XmlActionResult(data, contentType, statusCode);
                case ContentTypes.Json:
                    return new JsonActionResult(data, contentType, statusCode);
                default:
                    throw Errors.ContentTypeNotSupported(contentType);
            }
        }
    }
}
