using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using EersteTest.Controllers;
using EersteTest.Models;
using EersteTest.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EersteTest.Tests.Controllers
{
    [TestClass]
    public class CoffeeMachineControllerTest
    {
        CoffeeMachineController coffeeMachineController = new CoffeeMachineController();

        [TestMethod]
        public void PostCoffeeMachine()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Coffee"));
            products.Add(new Product("Thea"));
            products.Add(new Product("Water"));
            int coffeeMachineId = coffeeMachineController.PostCoffeeMachine(new CoffeeMachineViewModel(products));
            Assert.AreEqual(1, coffeeMachineId, "A coffeemachine should be made.");
        }
    }

    
}
