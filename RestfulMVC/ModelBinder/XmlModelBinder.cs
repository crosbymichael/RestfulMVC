using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RestfulMVC.Serializer;

namespace RestfulMVC.ModelBinder
{
    class XmlModelBinder : RestfulModelBinderBase
    {
        public override object Deserialize(Stream stream, Type type)
        {
            var serializer = Bucket.Resolve<XmlSerializer>();
            return serializer.Deserialize(stream, type);
        }

        public override string ContentType
        {
            get { return "xml"; }
        }

        public override bool IsReusable
        {
            get { return true; }
        }
    }
}
