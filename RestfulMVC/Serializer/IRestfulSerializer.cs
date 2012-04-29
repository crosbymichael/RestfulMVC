using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace RestfulMVC.Serializer
{
    interface IRestfulSerializer : IDisposable
    {
        object Deserialize(Stream stream, Type type);
        MemoryStream Serialize(object data);
    }
}
