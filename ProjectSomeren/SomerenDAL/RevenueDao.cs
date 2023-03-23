using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT [order_ID], [student_ID], [drink_ID], [voucher], [date] " +
                            "FROM dbo.orders";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadOrderTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    ID = (int)dr["order_ID"],
                    StudentID = (int)dr["student_ID"],
                    DrinkID = (int)dr["drink_ID"],
                    Voucher = (bool)dr["voucher"],
                    OrderDate = DateTime.Parse(dr["date"].ToString()),
                };
                orders.Add(order);
            }
            return orders;
        }

        public List<Sale> GetAllSales()
        {
            string query = "SELECT D.[name] AS Drink_Name, COUNT(O.[drink_ID]) AS Amount " +
                            "FROM dbo.drinks AS D " +
                            "JOIN dbo.orders AS O ON D.[drink_ID]=O.[drink_ID] " +
                            "GROUP BY D.[name] ";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadSaleTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Sale> ReadSaleTables(DataTable dataTable)
        {
            List<Sale> sales = new List<Sale>();
            int count = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                Sale sale = new Sale()
                {
                    ID = count,
                    Name = dr["Drink_Name"].ToString(),
                    Amount = (int)dr["Amount"],
                };
                sales.Add(sale);
                count++;
            }
            return sales;
        }

        public List<Customer> GetAllCustomers()
        {
            string query = "SELECT S.[first_name], S.[last_name], COUNT(O.[student_ID]) AS Amount " +
                            "FROM dbo.students AS S " +
                            "JOIN dbo.orders AS O ON S.[student_ID]=O.[student_ID] " +
                            "JOIN dbo.drinks AS D ON O.[drink_ID]=D.[drink_ID] " +
                            "GROUP BY S.[first_name], S.[last_name] " +
                            "HAVING COUNT(D.[drink_ID]) >= 1";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCustomerTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Customer> ReadCustomerTables(DataTable dataTable)
        {
            List<Customer> customers = new List<Customer>();
            int count = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                Customer customer = new Customer()
                {
                    ID = count,
                    FirstName = dr["first_name"].ToString(),
                    LastName = dr["last_name"].ToString(),
                    Amount = (int)dr["Amount"],
                };
                customers.Add(customer);
                count++;
            }
            return customers;
        }
    }
}
