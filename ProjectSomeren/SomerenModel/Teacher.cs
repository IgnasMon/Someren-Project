using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int Id { get; set; }                     // DB - lecturer_ID
        public string FirstName { get; set; }           // DB - first_name
        public string LastName { get; set; }            // DB - last_name
        public DateTime DateOfBirth { get; set; }       // DB - date_of_birth
        public string TelephoneNumber { get; set; }     // DB - telephone_number
        public bool IsSupervisor { get; set; }           // DB - is_supervisor
        public int RoomID { get; set; }                 // DB - room_ID

        public string FullName 
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}