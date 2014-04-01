using System;
using EersteTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EersteTest.Tests.unitTests
{
    [TestClass]
    public class CoffeeMachineTests
    {
        [TestMethod]
        public void AddProductToCoffeeMachine()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Product product = new Product("Coffee");
            coffeeMachine.AddProduct(product);

            Assert.AreEqual(coffeeMachine.GetProductById(product.ProductId), product, "Products must be equal");
        }
    }
}
