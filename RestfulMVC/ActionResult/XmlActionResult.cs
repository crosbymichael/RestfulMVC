using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using RestfulMVC.Serializer;

namespace RestfulMVC.ActionResult
{
    class XmlActionResult : RestfulActionResultBase
    {
        protected override Serializer.IRestfulSerializer Serializer
        {
            get { return Bucket.Instance.Resolve<XmlSerializer>(); }
        }

        public XmlActionResult(object data, ContentTypes contentType, HttpStatusCode statusCode)
            : base(data, contentType, statusCode)
        { 
            
        }
    }
}
