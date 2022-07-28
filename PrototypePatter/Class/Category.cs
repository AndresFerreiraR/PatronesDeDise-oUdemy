using PrototypePatter.Interface;

namespace PrototypePatter.Class
{
    public class Category : IPrototype<Category>
    {
        public string Name { get; set; }

        public Category(string _Name)
        {
            this.Name = _Name;
        }

        //public object Clone()
        //{
        //    return new Category(this.Name);
        //}

        public Category DeepCoppy()
        {
            return new Category(this.Name);
        }
    }
}