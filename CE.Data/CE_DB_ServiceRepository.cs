using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Repository;
using CE.Core.Domain;

namespace CE.Data
{
    /// <summary>
    /// Service Repository from database implementation
    /// </summary>
    public class CE_DB_ServiceRepository : ICustomerOrderRepository
    {
        /// <summary>
        /// Get customer order data based on customer Id
        /// </summary>
        /// <param name="customer_Id"></param>
        /// <returns></returns>
        public IEnumerable<CustomerOrder> GetCustomerOrder(int customer_Id)
        {
            try
            {
                using (var dataContext = new SEDataClassesDataContext())
                {
                    var customers = dataContext.Customers;
                    var orders = dataContext.Orders;

                    var result = (from customer in customers
                                  join order in orders on customer.Id equals order.Customer_Id
                                  where customer.Id == customer_Id
                                  select new CustomerOrder() { Customer_Name = customer.Name, Order_Name = order.Name, Order_Date = order.Order_Date, Order_Price = order.Price }).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
