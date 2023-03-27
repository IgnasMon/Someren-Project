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
    // All Orders
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

    // All Sales
        public List<Sale> GetAllSales(string dateStart, string dateEnd)
        {
            string query = "Select Distinct D.[name] AS Drink_Name, D.[price] AS Price, D.[is_alcoholic] AS Alcoholic, (select COUNT(*) " +
                                                                    "from dbo.orders AS O " +
                                                                    "WHERE O.[drink_ID]= D.[drink_ID] " +
                                                                    "AND O.[date] BETWEEN @startDate AND @endDate) AS Amount " +
                            "FROM dbo.drinks AS D " +
                            "JOIN dbo.orders AS O ON D.[drink_ID] = O.[drink_ID]";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            // Swaping query @ parameters
            AssignSqlParameter(sqlParameters, 0, SqlDbType.Date, "@startDate", dateStart);
            AssignSqlParameter(sqlParameters, 1, SqlDbType.Date, "@endDate", dateEnd);

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
                    IsAlcoholic = (bool)dr["Alcoholic"],
                    Price = (decimal)dr["Price"],
                    Amount = (int)dr["Amount"],
                };
                sales.Add(sale);
                count++;
            }
            return sales;
        }

        // Customers
        // All Customers
        public List<Customer> GetAllCustomers(string dateStart, string dateEnd)
        {
            string query = "Select Distinct S.[first_name], S.[last_name], " +
                                    "(select COUNT(*) " +
                                    "from dbo.orders AS O " +
                                    "WHERE O.[student_ID]= S.[student_ID] " +
                                    "AND O.[date] BETWEEN @startDate AND @endDate) AS Amount " +
                            "FROM dbo.students AS S " +
                            "JOIN dbo.orders AS O ON S.[student_ID] = O.[student_ID]";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            // Swaping query @ parameters
            AssignSqlParameter(sqlParameters, 0, SqlDbType.Date, "@startDate", dateStart);
            AssignSqlParameter(sqlParameters, 1, SqlDbType.Date, "@endDate", dateEnd);

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

        // Total Customers
        public int GetTotalCustomers(string dateStart, string dateEnd)
        {
            string query = "Select Count(O.[order_ID]) AS Amount " +
                            "from dbo.orders AS O " +
                            "Where O.[date] BETWEEN @startDate AND @endDate";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            // Swaping query @ parameters
            AssignSqlParameter(sqlParameters, 0, SqlDbType.Date, "@startDate", dateStart);
            AssignSqlParameter(sqlParameters, 1, SqlDbType.Date, "@endDate", dateEnd);

            return ReadTotalCustomerTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private int ReadTotalCustomerTables(DataTable dataTable)
        {
            int totalCustomers = (int)dataTable.Rows[0]["Amount"];
            return totalCustomers;
        }

        private void AssignSqlParameter(SqlParameter[] sqlParameters, int index, SqlDbType dataType, string parameterName, string parameterValue)
        {
            // Swaping query @ parameters
            sqlParameters[index] = new SqlParameter();
            sqlParameters[index].SqlDbType = dataType;
            sqlParameters[index].ParameterName = parameterName;
            sqlParameters[index].Value = parameterValue;
        }
    }
}
