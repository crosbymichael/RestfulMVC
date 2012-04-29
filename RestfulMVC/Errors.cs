using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulMVC
{
    /// <summary>
    /// Common interface for all Exceptions thrown by the framework
    /// </summary>
    static class Errors
    {
        public static Exception ContentTypeNotSupported(ContentTypes contentType)
        { 
            return new Exception(string.Format(
                RestfulContent.ContentTypeNotSupported,
                contentType.ToString()));
        }

        public static Exception InvalidObjectForSerializer(string type)
        {
            return new Exception();
        }

        public static Exception ObjectNotSerializable()
        {
            return new Exception();
        }

        public static Exception ResourceNotFound(string name)
        {
            return new Exception();
        }
    }
}
