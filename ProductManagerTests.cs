using NUnit.Framework;
using Clases;
using System;

namespace ClasesTests
{
    public class ProductManagerTests
    {
        private ProductManager _productManager;

        [SetUp]
        public void Setup()
        {
            _productManager = new ProductManager();
        }


        // ::::: TEST 1 :::::


        [Test]
        public void Product_CreacionCorrecta_con_IdNombrePrecioYCategoriay()
        {
            // ::::: Datos :::::
            var product = new Product(1, "Auricular Inalámbrico", 1000m, "Electrónica");

            // ::::: Pruebas :::::
            Assert.That(product.Id, Is.EqualTo(1));
            Assert.That(product.Name, Is.EqualTo("Auricular Inalámbrico"));
            Assert.That(product.Price, Is.EqualTo(1000m));
            Assert.That(product.Category, Is.EqualTo("Electrónica"));
        }


        // ::::: TEST 2 :::::


        [Test]
        public void AddProduct_AgregacionCorrecta_Producto()
        {
            // ::::: Datos :::::
            var product = new Product(2, "Pendrive", 500m, "Electrónica");
            _productManager.AddProduct(product);
            var allProducts = _productManager.GetAllProducts();

            // ::::: Pruebas :::::
            Assert.That(allProducts, Contains.Item(product));
            Assert.That(allProducts.Count, Is.EqualTo(1));
        }


        // ::::: TEST 3 :::::


        [Test]
        public void FindProductByName_AgregarVariosProductos_y_EcontrarPorNombre()
        {
            // ::::: Datos :::::
            var product1 = new Product(3, "Teclado", 150m, "Electrónica");
            var product2 = new Product(4, "Pan", 2m, "Alimentos");
            _productManager.AddProduct(product1);
            _productManager.AddProduct(product2);
            var foundProduct = _productManager.FindProductByName("Teclado");

            // ::::: Pruebas :::::
            Assert.That(foundProduct, Is.Not.Null);
            Assert.That(foundProduct, Is.EqualTo(product1));
        }


        // ::::: TEST 4 :::::


        [Test]
        public void CalculateTotalPrice_CalcularCorrectamente_PrecioTotalConImpuestos_Electronica()
        {
            // ::::: Datos :::::
            var product = new Product(5, "Tablet", 300m, "Electrónica");
            _productManager.AddProduct(product);
            var totalPrice = _productManager.CalculateTotalPrice(5);

            // ::::: Pruebas :::::
            Assert.That(totalPrice, Is.EqualTo(330m), "El precio total con impuestos para Electrónica no fue el esperado.");
        }


        // ::::: TEST 5 :::::


        [Test]
        public void CalculateTotalPrice_CalcularCorrectamente_PrecioTotalConImpuestos_Alimentos()
        {
            // ::::: Datos :::::
            var product = new Product(6, "Fideos", 1m, "Alimentos");
            _productManager.AddProduct(product);
            var totalPrice = _productManager.CalculateTotalPrice(6);

            // ::::: Pruebas:::::
           Assert.That(totalPrice, Is.EqualTo(1.05m), "El precio total con impuestos para Alimentos no fue el esperado.");
        }
    }
}
