using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using RestfulMVC.Serializer;

namespace RestfulMVC.ActionResult
{
    class JsonActionResult : RestfulActionResultBase
    {
        protected override Serializer.IRestfulSerializer Serializer
        {
            get { return Bucket.Instance.Resolve<JsonSerializer>(); }
        }

        public JsonActionResult(object data, ContentTypes contentType, HttpStatusCode statusCode)
            : base(data, contentType, statusCode)
        { 
            
        }
    }
}
