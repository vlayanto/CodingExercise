using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using CE.Core.Domain;
using CE.Web.Models;

namespace CE.Web.Controllers
{
    public class CustomerOrderDataController : Controller
    {
        // GET: CustomerOrderList
        /// <summary>
        /// Display Customer Order Data List based on customer Id as a parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ViewResult Index(int id)
        {
            try
            {
                IEnumerable<CustomerOrder> modelCollection = null;
                using (var client = new HttpClient())
                {
                    var customerOrderAPIUrl = Url.RouteUrl("DefaultApi",
                        new { httproute = "api", controller = "CustomerOrder", id = id },
                        Request.Url.Scheme);
                    modelCollection = client.GetAsync(customerOrderAPIUrl).Result.Content.ReadAsAsync<IEnumerable<CustomerOrder>>().Result;
                }

                if (modelCollection != null)
                {
                    return View(new CustomerOrderViewModel() { CustomerOrders = modelCollection });
                }
                else
                {
                    return View(new CustomerOrderViewModel() { CustomerOrders = new List<CustomerOrder>() });
                }
            }
            catch (Exception ex)
            {
                // TODO - Log the error
                throw ex;
            }
        }
    }
}