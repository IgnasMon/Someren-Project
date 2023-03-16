using System;

namespace SomerenModel
{
    public class Student
    {
        public int student_ID { get; set; }     // database Primary Key
        public string clas { get; set; }        // written as clas since visual studio will complain about using class
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string telephone_number { get; set; }
        public int room_ID { get; set; }     

    }
}