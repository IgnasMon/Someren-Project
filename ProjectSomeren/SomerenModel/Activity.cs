﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{    
        public class Activity 
        {
            public int Activity_ID { get; set; }     // database Primary Key
            public string Description { get; set; }
            public DateTime StartDateTime{ get; set; }
            public DateTime EndDateTime { get; set; }
        }    
}
