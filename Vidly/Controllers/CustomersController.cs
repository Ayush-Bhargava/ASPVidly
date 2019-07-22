using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers")]
        public ActionResult Customers()
        {
            CustomersViewModel customers = new CustomersViewModel();
            customers.Customers = new List<Customer>()
            {
                new Customer {Id=1,Name = "Kenna Dahlgren"},
                new Customer {Id=2,Name = "Dylan Sheats"},
                new Customer {Id=3,Name = "Veola Then"},
                new Customer {Id=4,Name = "Wyatt Everly"},
                new Customer {Id=5,Name = "Lyndsey Uchida"},
                new Customer {Id=6,Name = "Leonardo Folkerts"},
            };

            return View(customers);
        }
        //Customers/Details/{id}
        public ActionResult Details(int id)
        {
            CustomersViewModel customers = new CustomersViewModel();
            customers.Customers = new List<Customer>()
            {
                new Customer {Id=1, Name = "Kenna Dahlgren"},
                new Customer {Id=2, Name = "Dylan Sheats"},
                new Customer {Id=3, Name = "Veola Then"},
                new Customer {Id=4, Name = "Wyatt Everly"},
                new Customer {Id=5, Name = "Lyndsey Uchida"},
                new Customer {Id=6, Name = "Leonardo Folkerts"},
            };
            Customer customer = new Customer();
            customer = customers.Customers.Where(t => t.Id == id).FirstOrDefault();
            if (customer != null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}