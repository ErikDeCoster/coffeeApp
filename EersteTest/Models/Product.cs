using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EersteTest.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public Product(string productName)
        {
            ProductName = productName;
        }

    }
}