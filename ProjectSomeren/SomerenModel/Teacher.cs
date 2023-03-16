using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int Id { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}