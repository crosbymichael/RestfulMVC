using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RestfulMVC.Serializer;

namespace RestfulMVC.ModelBinder
{
    class JsonModelBinder : RestfulModelBinderBase
    {
        public override object Deserialize(Stream stream, Type type)
        {
            var serializer = Bucket.Resolve<JsonSerializer>();
            return serializer.Deserialize(stream, type);
        }

        public override string ContentType
        {
            get { return "json"; }
        }

        public override bool IsReusable
        {
            get { return true; }
        }
    }
}
