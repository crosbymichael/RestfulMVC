using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RestfulMVC.Serializer;

namespace RestfulMVC.ModelBinder
{
    abstract class RestfulModelBinderBase : IBucketResource
    {
        public abstract object Deserialize(Stream stream, Type type);
        public abstract string ContentType { get; }

        protected Bucket Bucket 
        {
            get { return Bucket.Instance; }
        }

        public abstract bool IsReusable
        {
            get;
        }
    }
}
