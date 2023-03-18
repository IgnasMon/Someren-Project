using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    
    
        public class Activity 
        {
            public int Schedule_ID { get; set; }     // database Primary Key
            public string Capacity { get; set; }
            public int Lecturer_ID{ get; set; }
            public int Student_ID { get; set; }
            

        }
        
    
}
