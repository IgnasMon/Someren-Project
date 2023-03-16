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

        /*public List<Student> GetAllStudents()
        {
            string query = "SELECT * FROM dbo.lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }*/

        /*private List<Student> ReadTables(DataTable dataTable)
        {
            List<Teacher> lecturer = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["StudentId"],
                    Name = dr["Name"].ToString()
                };
                students.Add(student);
            }
            return students;
        }*/
    }
}
