using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Core.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
