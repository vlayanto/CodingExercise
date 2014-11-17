using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CE.Core.Domain;

namespace CE.Web.Models
{
    public class CustomerOrderViewModel
    {
        public IEnumerable<CustomerOrder> CustomerOrders { get; set; }
    }
}