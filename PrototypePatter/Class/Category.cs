namespace PrototypePatter.Class
{
    public class Category : ICloneable
    {
        public string Name { get; set; }

        public Category(string _Name)
        {
            this.Name = _Name;
        }

        public object Clone()
        {
            return new Category(this.Name);
        }
    }
}