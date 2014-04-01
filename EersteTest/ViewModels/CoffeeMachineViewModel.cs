using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EersteTest.Models;

namespace EersteTest.ViewModels
{
    public class CoffeeMachineViewModel
    {
        private readonly List<Product> _products;

        public List<Product> Products
        {
            get { return _products; }
        }

        public CoffeeMachineViewModel(List<Product> products)
        {
            _products = products;
        }
    }
}