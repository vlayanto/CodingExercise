using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Domain;

namespace CE.Core.Repository
{
    /// <summary>
    /// Customer Repository Interface
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Get All Customer Data
        /// </summary>
        IEnumerable<Customer> Customers { get; }
    }
}
