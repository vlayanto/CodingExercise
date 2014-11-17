using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CE.Data;
using CE.Service;

namespace CE.Web.Controllers
{
    /// <summary>
    /// Customer Order API Controller
    /// </summary>
    public class CustomerOrderController : ApiController
    {
        // GET api/customerorder/5
        /// <summary>
        /// Get method for customer order based on customer id parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A collection of customer order as JSON format (default)</returns>
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var dbRepository = new CE_DB_ServiceRepository();
                var customerOrderService = new CustomerOrderService(dbRepository);
                var customerOrderData = customerOrderService.GetCustomerOrder(id);

                return Request.CreateResponse(HttpStatusCode.OK, customerOrderData);
            }
            catch (Exception ex)
            {
                // TODO - log the exception so the app won't miss the error.
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { ReasonPhrase = "Error has occured" });
            }
            
        }
    }
}