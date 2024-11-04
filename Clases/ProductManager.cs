using System;
using System.Collections.Generic;
using System.Linq;

namespace Clases
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        // ::::: Método para agregar un producto :::::
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // ::::: Método para calcular el precio total con impuestos según la categoría :::::
        public decimal CalculateTotalPrice(int productId)
        {
            var product = products.Find(p => p.Id == productId);

            if (product != null)
            {
                decimal taxRate = 0m;

                // ::::: Determina el impuesto según la categoría :::::
                if (product.Category == "Electrónica")
                {
                    taxRate = 0.10m; // 10% para Electrónica
                }
                else if (product.Category == "Alimentos")
                {
                    taxRate = 0.05m; // 5% para Alimentos
                }
                else
                {
                    throw new ArgumentException("Categoría desconocida.");
                }

                // ::::: Calcula el precio total con el impuesto adecuado :::::
                return product.Price * (1 + taxRate);
            }
            else
            {
                throw new ArgumentException("Producto no encontrado.");
            }
        }

        // ::::: Método para buscar un producto por su nombre :::::
        public Product? FindProductByName(string name)
        {
            return products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // ::::: Método para listar todos los productos :::::
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
