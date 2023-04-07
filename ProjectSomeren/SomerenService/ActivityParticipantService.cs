using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivityParticipantService
    {
        private ActivityParticipantDao activityParticipantdb;

        public ActivityParticipantService()
        {
            activityParticipantdb = new ActivityParticipantDao();
        }

        public List<ActivityParticipant> GetActivityParticipants()
        {
            List<ActivityParticipant> activityParticipants = activityParticipantdb.GetAllActivityParticipants(); 
            return activityParticipants;
        }
    }
}
