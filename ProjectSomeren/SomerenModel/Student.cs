using System;

namespace SomerenModel
{
    public class Student
    {
        public int StudentID { get; set; }     // database Primary Key
        public string Class { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public int RoomID { get; set; }     

    }
}