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

        public List<Sale> GetSales(string dateStart, string dateEnd)
        {
            List<Sale> sales = revenuedb.GetAllSales(dateStart, dateEnd);
            return sales;
        }

        public List<Customer> GetCustomers(string dateStart, string dateEnd)
        {
            List<Customer> customers = revenuedb.GetAllCustomers(dateStart, dateEnd);
            return customers;
        }
        
      /*  public List<Customer> GetTotalCustomers(string dateStart, string dateEnd)
        {
            Customer customers = revenuedb.GetTotalCustomers(dateStart, dateEnd);
            return customers;
        }*/
    }
}
