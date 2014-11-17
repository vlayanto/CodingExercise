using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Domain;

namespace CE.Core.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
    }
}
