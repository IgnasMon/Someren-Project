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
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT drink_ID, [name], is_alcoholic, price FROM dbo.drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Drink_ID = (int)dr["drink_ID"],
                    Name = dr["name"].ToString(),
                    Is_Alcoholic = (bool)dr["is_alcoholic"],
                    Price = (decimal)dr["price"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
