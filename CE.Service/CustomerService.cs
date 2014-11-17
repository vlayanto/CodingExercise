using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Repository;
using CE.Core.Domain;

namespace CE.Service
{
    /// <summary>
    /// Customer Service
    /// </summary>
    public class CustomerService
    {
        private ICustomerRepository customerRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customerRepository"></param>
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        /// <summary>
        /// Get Customer List
        /// </summary>
        /// <returns>Collection of Customer Domain Model</returns>
        public IEnumerable<Customer> GetCustomerList()
        {
            return customerRepository.Customers;
        }
    }
}
