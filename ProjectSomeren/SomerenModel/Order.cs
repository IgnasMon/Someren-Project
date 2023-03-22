using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int DrinkID { get; set; }
        public bool Voucher { get ; set; }
        public DateTime OrderDate { get; set; }
    }
}
