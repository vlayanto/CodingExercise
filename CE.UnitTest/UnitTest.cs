using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CE.Core.Domain;

namespace CE.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        private MockRepository mockRepository = null;

        [TestInitialize]
        public void Setup()
        {
            mockRepository = new MockRepository();
        }

        [TestMethod]
        public void CustomerOrderRepository_GetCustomerList_ReturnData()
        {
            // Assert if customer repository is not null
            Assert.IsNotNull(mockRepository.Customers);
        }

        [TestMethod]
        public void CustomerOrderRepository_GetCustomerOrderData_ReturnData()
        {
            // Assert if customer Id = 1 has order placed.
            var customerOrderData = mockRepository.GetCustomerOrder(1) as List<CustomerOrder>;
            Assert.AreEqual(2, customerOrderData.Count);
        }

        [TestMethod]
        public void CustomerOrderRepository_GetCustomerOrderData_NoReturnData()
        {
            // Assert if customer Id = 2 doesn't have order placed.
            var customerOrderData = mockRepository.GetCustomerOrder(2) as List<CustomerOrder>;
            Assert.AreEqual(0, customerOrderData.Count);
        }

        [TestCleanup]
        public void CleanUp()
        {
            mockRepository = null;
        }
    }
}
