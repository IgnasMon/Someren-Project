using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class ActivityParticipantDao : BaseDao
    {
        public List<ActivityParticipant> GetAllActivityParticipants()
        {
            string query = "SELECT activity_ID, student_ID FROM dbo.activityParticipants";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ActivityParticipant> ReadTables(DataTable dataTable)
        {
            List<ActivityParticipant> activityParticipants = new List<ActivityParticipant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivityParticipant activityParticipant = new ActivityParticipant()
                {
                    Activity_ID = (int)dr["activity_ID"],
                    Student_ID = (int)dr["student_ID"]
                };
                activityParticipants.Add(activityParticipant);
            }
            return activityParticipants;
        }

        public void AddActivityParticipant(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveActivityParticipant(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
