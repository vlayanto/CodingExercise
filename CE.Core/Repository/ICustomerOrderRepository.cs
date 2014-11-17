using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Domain;

namespace CE.Core.Repository
{
    /// <summary>
    /// Customer Order Repository Interface
    /// </summary>
    public interface ICustomerOrderRepository
    {
        /// <summary>
        /// Get All Customer Order based on customer Id
        /// </summary>
        /// <param name="customer_Id"></param>
        /// <returns></returns>
        IEnumerable<CustomerOrder> GetCustomerOrder(int customer_Id);
    }
}
