using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web.Mvc;
using RestfulMVC.Serializer;

namespace RestfulMVC.ActionResult
{
    abstract class RestfulActionResultBase : System.Web.Mvc.ActionResult
    {
        protected abstract IRestfulSerializer Serializer { get; }

        protected object data;
        protected ContentTypes contentType;
        protected HttpStatusCode statusCode;

        public RestfulActionResultBase(object data, ContentTypes contentType, HttpStatusCode statusCode)
        {
            this.data = data;
            this.contentType = contentType;
            this.statusCode = statusCode;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;

            response.StatusCode = (int)statusCode;
            
            if (contentType != ContentTypes.Null)
            {
                response.ContentType = string.Format(
                    RestfulContent.ContentTypeApplication,
                    contentType.ToString().ToLower());
            }

            if (data != null)
            {
                if (contentType == ContentTypes.Json ||
                    contentType == ContentTypes.Xml)
                {
                    //Add model response type so clients know how to deserialize the response
                    response.AddHeader(RestfulContent.Expect, data
                        .GetType()
                        .AssemblyQualifiedName);
                }

                try
                {
                    var stream = Serializer.Serialize(data);
                    response.BinaryWrite(stream.ToArray());
                }
                catch (Exception e)
                {
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    response.StatusDescription = RestfulContent.ResponseSerializationFailed;
                    response.ContentType = string.Empty;
                }
            }   
        }
    }
}
