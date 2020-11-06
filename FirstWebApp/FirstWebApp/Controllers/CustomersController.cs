using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApp.Models;
using FirstWebApp.ViewModels;

namespace FirstWebApp.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
             new Customer {Name = "Joaquim",Id = 1},
             new Customer {Name = "Maria Alberta",Id = 2}
        };


        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        [Route("CustomersList")]
        public ActionResult CustomerList()
        {
            var customersList = new CustomersListViewModel() { Customers = customers };
            return View(customersList);
        }
        [Route("Details/{id}")]
        public ActionResult CustomerInfo(int id)
        {

            return View();
        }
    }
}