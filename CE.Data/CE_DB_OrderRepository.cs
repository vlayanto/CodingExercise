using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Repository;
using CE.Core.Domain;

namespace CE.Data
{
    public class CE_DB_OrderRepository : IOrderRepository, IDisposable
    {
        private SEDataClassesDataContext dataContext = new SEDataClassesDataContext();

        public IEnumerable<CE.Core.Domain.Order> Orders
        {
            get
            {
                var result = new List<CE.Core.Domain.Order>();
                dataContext.Orders.ToList().ForEach(data =>
                    {
                        result.Add(new CE.Core.Domain.Order() { Id = data.Id, Customer_Id = data.Customer_Id, Name = data.Name, Date = data.Order_Date, Price = data.Price });
                    });
                return result;
            }
        }

        public void Dispose()
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }
    }
}
