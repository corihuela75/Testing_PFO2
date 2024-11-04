namespace Clases
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio base de un producto no puede ser negativo.");
                }
                _price = value;
            }
        }
        public string Category { get; set; } // Electrónica" o "Alimentos"


        public Product(int id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
