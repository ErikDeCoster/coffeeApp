using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EersteTest.Models
{
    public class CoffeeMachine
    {
        public int coffeeMachineId { get; set; }
        
        private List<Product> products;

        public CoffeeMachine()
        {
            products = new List<Product>();
        }

        public List<Product> Products
        {
            get { return products; }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public Product GetProductById(int productId)
        {
            return products.First(p => p.ProductId == productId);
        }

        public int getCoffeeMachineId()
        {
            return coffeeMachineId;
        }
    }
}