using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Domain;

namespace CE.Core.Service
{
    /// <summary>
    /// Customer Service Interface
    /// </summary>
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomerList();
    }
}
