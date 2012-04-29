using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestfulMVC.ModelBinder;
using RestfulMVC.Serializer;

namespace RestfulMVC
{
    public sealed class RestfulMVC
    {
        Bucket bucket;
        public void Init()
        {
            bucket = Bucket.Instance;

            bucket.Register<XmlModelBinder>(() => new XmlModelBinder());
            bucket.Register<XmlSerializer>(() => new XmlSerializer());
            bucket.Register<JsonModelBinder>(() => new JsonModelBinder());
            bucket.Register<JsonSerializer>(() => new JsonSerializer());
            bucket.Register<StringSerializer>(() => new StringSerializer());
        }
    }
}
