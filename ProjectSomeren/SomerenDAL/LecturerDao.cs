using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {

        public List<Teacher> GetAllLecturers()
        {
            string query = "SELECT [lecturer_ID], [first_name], [last_name], [date_of_birth], [telephone_number], [is_supervisor], [room_ID] " +
                            "FROM dbo.lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> lecturers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher lecturer = new Teacher()
                {
                    Id = (int)dr["lecturer_ID"],
                    FirstName = dr["first_name"].ToString(),
                    LastName = dr["last_name"].ToString(),
                    DateOfBirth = DateTime.Parse(dr["date_of_birth"].ToString()),
                    TelephoneNumber = dr["telephone_number"].ToString(),
                    IsSupervisor = (bool)dr["is_supervisor"],
                    RoomID = (int)dr["room_ID"]
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
