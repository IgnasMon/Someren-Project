using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RevenueService
    {
        private RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = revenuedb.GetAllOrders();
            return orders;
        }

        public List<Sale> GetSales()
        {
            List<Sale> sales = revenuedb.GetAllSales();
            return sales;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = revenuedb.GetAllCustomers();
            return customers;
        }
    }
}
