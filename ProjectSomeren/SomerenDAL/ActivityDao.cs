using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;
using Microsoft.VisualBasic;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
    // Activity - Sagy
        public List<Activity> GetAllActivities() // Ignas - Changed the method name from GetAllActivity -> GetAllActivities
        {
            // Ignas - Changed the query so it doesn't SELECT everything using *, but SELECT everything using their column names
            //string query = "SELECT * FROM dbo.activities";
            string query = "SELECT Act.[activity_ID], " +
                                    "Act.[description], " +
                                    "Act.[startDateTime], " +
                                    "Act.[endDateTime] " +
                                "FROM dbo.Activities AS Act";
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
    // Activity - End

    // ActivityCRUD - Ignas - Assignment 4
        public void AddActivity(Activity activity)
        {
            string query = "INSERT INTO dbo.activities(description, startDateTime, endDateTime) " +
                            "Values(@Desc, @StartDate, @EndDate)";
            SqlParameter[] sqlParameters;

            try
            {
                sqlParameters = new SqlParameter[3];

                // Swaping query @ parameters
                AssignSqlParameter(sqlParameters, 0, SqlDbType.VarChar, "@Desc", activity.Description.ToString());
                AssignSqlParameter(sqlParameters, 1, SqlDbType.Date, "@StartDate", activity.StartDateTime.ToString());
                AssignSqlParameter(sqlParameters, 2, SqlDbType.Date, "@EndDate", activity.EndDateTime.ToString());

                ExecuteEditQuery(query, sqlParameters);
            }catch (Exception ex)
            {
                throw new Exception("Exception when creating a new Activity:\n", ex);
            }

        }

        public void UpdateActivity(Activity activity)
        {
            string query = "UPDATE dbo.activities " +
                            "SET[description] = @Desc, " +
                                "[startDateTime] = @StartDate, " +
                                "[endDateTime] = @EndDate " +
                            "WHERE[activity_ID] = @ID;";
            SqlParameter[] sqlParameters;

            try
            {
                sqlParameters = new SqlParameter[4];

                // Swaping query @ parameters
                AssignSqlParameter(sqlParameters, 0, SqlDbType.VarChar, "@Desc", activity.Description.ToString());
                AssignSqlParameter(sqlParameters, 1, SqlDbType.Date, "@StartDate", activity.StartDateTime.ToString());
                AssignSqlParameter(sqlParameters, 2, SqlDbType.Date, "@EndDate", activity.EndDateTime.ToString());
                AssignSqlParameter(sqlParameters, 3, SqlDbType.VarChar, "@ID", activity.Activity_ID);

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Exception when deleting Activity:\n", ex);
            }
        }

        public void RemoveActivity(Activity activity)
        {
            string query = "DELETE FROM dbo.activities " +
                            "WHERE [activity_ID]=@ID ";
            SqlParameter[] sqlParameters;

            try
            {
                sqlParameters = new SqlParameter[1];

                // Swaping query @ parameters
                AssignSqlParameter(sqlParameters, 0, SqlDbType.VarChar, "@ID", activity.Activity_ID);

                ExecuteEditQuery(query, sqlParameters);
            }catch (Exception ex)
            {
                throw new Exception("Exception when deleting Activity:\n", ex);
            }
        }
    // ActivityCRUD - End
    }
}