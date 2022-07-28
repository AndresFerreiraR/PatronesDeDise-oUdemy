using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatter.Class
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var stram = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stram, self);
            stram.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stram);
            stram.Close();
            return (T)copy;

        }
    }
}
