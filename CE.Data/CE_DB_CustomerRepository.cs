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
    /// Customer Repository from database implementation
    /// </summary>
    public class CE_DB_CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Get customer collection
        /// </summary>
        public IEnumerable<CE.Core.Domain.Customer> Customers
        {
            get
            {
                using (var dataContext = new SEDataClassesDataContext())
                {
                    var result = new List<CE.Core.Domain.Customer>();
                    dataContext.Customers.ToList().ForEach(data =>
                    {
                        result.Add(new CE.Core.Domain.Customer() { ID = data.Id, Name = data.Name });
                    });

                    return result;
                }
            }
        }
    }
}
