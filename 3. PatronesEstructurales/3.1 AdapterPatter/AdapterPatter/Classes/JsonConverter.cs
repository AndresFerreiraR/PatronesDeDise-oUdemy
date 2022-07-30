using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatter.Classes
{
    public class JsonConverter
    {
        public string GetJson()
        {
            return JsonConvert.SerializeObject(ProductDataProvider.GetData(), Formatting.Indented);
        }
    }
}
