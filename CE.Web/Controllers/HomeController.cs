using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CE.Service;
using CE.Core.Domain;

namespace CE.Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            try
            {
                ViewBag.Title = "Coding Exercise - Customer";

                var customerRepository = new CE.Data.CE_DB_CustomerRepository();
                var customerService = new CustomerService(customerRepository);
                var customerList = customerService.GetCustomerList();

                if (customerList != null)
                {
                    return View(new CE.Web.Models.CustomerViewModel() { Customers = customerList as List<Customer> });
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                // TODO - Log the exception
                throw ex;
            }

        }
    }
}
