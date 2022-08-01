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

        private List<Product> products;

        public JsonConverter(List<Product> products)
        {
            this.products = products;
        }


        //public string GetJson()
        //{
        //    var result = JsonConvert.SerializeObject(products, Formatting.Indented);
        //    Console.WriteLine(result);
        //    return JsonConvert.SerializeObject(ProductDataProvider.GetData(), Formatting.Indented);
        //}

        public void ConvertToJson()
        {
            var result = JsonConvert.SerializeObject(products, Formatting.Indented);
            Console.WriteLine(result);
        }
    }
}
