using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    internal class RevenueService
    {
        private RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        /*public List<Teacher> GetLecturers()
        {
            List<Teacher> revenueList = revenuedb.GetAllLecturers();
            return revenueList;
        }*/
    }
}
