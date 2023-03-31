using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activity = activitydb.GetAllActivities(); // Ignas - Changed calling method name from GetAllActivity -> GetAllActivities
            return activity;
        }

        public void AddNewActivity(Activity activity)
        { 
            activitydb.AddActivity(activity);
        }

        public void UpdateActivity(Activity activity)
        {
            activitydb.UpdateActivity(activity);
        }

        public void RemoveActivity(Activity activity)
        {
            activitydb.RemoveActivity(activity);
        }
    }
}