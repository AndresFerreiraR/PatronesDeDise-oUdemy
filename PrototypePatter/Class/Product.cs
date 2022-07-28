using PrototypePatter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatter.Class
{
    [Serializable]
    public class Product /*: IPrototype<Product>*/
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public Product(string name, Category category)
        {
            this.Name = name;
            this.Category = category;
        }

        public override string ToString()
        {
            return $"Producto: {Name} Categoría: {Category.Name}";
        }

        //public object Clone()
        //{
        //    return new Product(Name, (Category)Category.Clone());
        //}

        //public Product DeepCoppy()
        //{
        //    return new Product(Name, Category.DeepCoppy());
        //}
    }
}
