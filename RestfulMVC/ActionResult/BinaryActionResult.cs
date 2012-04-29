using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace RestfulMVC.ActionResult
{
    class BinaryActionResult : RestfulActionResultBase
    {
        protected override Serializer.IRestfulSerializer Serializer
        {
            get { throw new NotImplementedException(); }
        }

        public BinaryActionResult(object data, ContentTypes contentType, HttpStatusCode statusCode)
            : base(data, contentType, statusCode)
        { 
            
        }
    }
}
