using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Core.Repository;
using CE.Core.Domain;

namespace CE.UnitTest
{
    class MockRepository : ICustomerOrderRepository, ICustomerRepository
    {
        private List<Customer> customerTable = new List<Customer>() {
            new Customer() { ID = 1, Name = "Cust1"},
            new Customer() { ID = 2, Name = "Cust2"}
        };

        private List<Order> orderTable = new List<Order>() {
            new Order() { Id = 1, Customer_Id = 1, Name = "Wireless Mouse", Date = new DateTime(2014, 11, 15), Price = 15.99M },
            new Order() { Id = 2, Customer_Id = 1, Name = "Flat Monitor", Date = new DateTime(2014, 11, 15), Price = 100.99M }
        };

        public IEnumerable<CustomerOrder> GetCustomerOrder(int customer_Id)
        {
            var result = (from customer in customerTable join
                         order in orderTable on customer.ID equals order.Customer_Id where customer.ID == customer_Id
                         select new CustomerOrder() { Customer_Name = customer.Name, Order_Name = order.Name, Order_Date = order.Date, Order_Price = order.Price }).ToList();

            return result;
        }

        public IEnumerable<Customer> Customers
        {
            get { return customerTable; }
        }
    }
}
