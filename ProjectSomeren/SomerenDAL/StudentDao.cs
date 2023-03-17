using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT student_ID, class, first_name, last_name, telephone_number, roomID FROM dbo.students";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentID = (int)dr["student_ID"],
                    Class = dr["class"].ToString(),
                    FirstName = dr["first_name"].ToString(),
                    LastName = dr["last_name"].ToString(),
                    TelephoneNumber = dr["telephone_number"].ToString(),
                    RoomID = (int)dr["roomID"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}