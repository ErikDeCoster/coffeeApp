using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EersteTest.Models
{
    public class Product
    {
        private string _productName;

        public Product(string productName)
        {
            _productName = productName;
        }
    public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public int ProductId { get; set; }
    }
}