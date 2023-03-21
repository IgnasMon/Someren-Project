using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

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
                    Schedule_ID = (int)dr["schedule_ID"],
                    Capacity = dr["capacity"].ToString(),
                    Lecturer_ID = (int) dr ["lecturer_ID"],
                    Student_ID = (int)dr["student_ID"],
                    
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}

