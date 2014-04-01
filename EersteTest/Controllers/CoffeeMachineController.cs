using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using EersteTest.Models;
using EersteTest.ViewModels;

namespace EersteTest.Controllers
{
    public class CoffeeMachineController : Controller
    {
        //
        // GET: /CoffeeMachine/
        public ActionResult Index()
        {
            return View();
        }

        public int PostCoffeeMachine(CoffeeMachineViewModel coffeeMachineViewModel)
        {
            CoffeeMachine coffeeMachine = null;
            if (coffeeMachineViewModel != null)
            {
                coffeeMachine = new CoffeeMachine();
                List<Product>products = coffeeMachineViewModel.Products;
                foreach(Product product in products)
                {
                    coffeeMachine.AddProduct(product);
                }
            }
            coffeeMachine.coffeeMachineId = 1;
            if (coffeeMachine != null) return coffeeMachine.getCoffeeMachineId();
            else
            {
                return 0;
            }
        }

        public string GetHelloWorld()
        {
            return "Hello World";
        }
    }
}