using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestfulMVC.ModelBinder;

namespace RestfulMVC
{
    static class RestfulModelBinderFactory
    {
        public static RestfulModelBinderBase GetBinder(string contentType)
        {
            if (contentType.Contains("xml"))
            {
                return Bucket.Instance.Resolve<XmlModelBinder>();
            }
            else if (contentType.Contains("json"))
            {
                return Bucket.Instance.Resolve<JsonModelBinder>();
            }

            return null;
        }
    }
}
