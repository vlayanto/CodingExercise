using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Domain;
using CE.Core.Repository;

namespace CE.Service
{
    /// <summary>
    /// Customer Order Service 
    /// </summary>
    public class CustomerOrderService
    {
        private ICustomerOrderRepository customerOrderRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customerOrderRepository"></param>
        public CustomerOrderService(ICustomerOrderRepository customerOrderRepository)
        {
            this.customerOrderRepository = customerOrderRepository;
        }

        /// <summary>
        /// Get Customer Order Data based on customer Id
        /// </summary>
        /// <param name="customer_Id"></param>
        /// <returns>Collection of CustomerOrder Domain Model</returns>
        public IEnumerable<CustomerOrder> GetCustomerOrder(int customer_Id)
        {
            return customerOrderRepository.GetCustomerOrder(customer_Id);
        }
    }
}
