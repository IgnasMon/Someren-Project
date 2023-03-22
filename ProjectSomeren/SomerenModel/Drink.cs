using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int Drink_ID { get; set; }     // database Primary Key
        public string Name { get; set; }
        public bool Is_Alcoholic { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
