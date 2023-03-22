using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT [order_ID], [student_ID], [drink_ID], [voucher], [date]" +
                            "FROM dbo.orders";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
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
    }
}
