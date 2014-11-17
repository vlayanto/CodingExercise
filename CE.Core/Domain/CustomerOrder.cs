using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Core.Domain
{
    /// <summary>
    /// Customer Order Domain Model
    /// </summary>
    public class CustomerOrder
    {
        public string Customer_Name { get; set; }
        public string Order_Name { get; set; }
        public DateTime Order_Date { get; set; }
        public decimal Order_Price { get; set; }
    }
}
