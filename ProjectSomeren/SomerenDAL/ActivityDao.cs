using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivity()
        {
            string query = "SELECT * FROM dbo.activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity > ReadTables(DataTable dataTable)
        {
            List <Activity> activities = new List<Activity >();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    Activity_ID = (int)dr["activity_ID"],
                    Description = dr["description"].ToString(),
                    StartDateTime = DateTime.Parse(dr["startDateTime"].ToString()),
                    EndDateTime = DateTime.Parse(dr["endDateTime"].ToString()),
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}