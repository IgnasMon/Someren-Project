using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class ActivityUI : Form
    {
        public ActivityUI()
        {
            InitializeComponent();
            ShowActivitiesPanel();
        }

        private void ShowActivitiesPanel()
        {
            try
            {
                // get and display all activities
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            listViewActivities.Clear();

            listViewActivities.Columns.Add("Schedule_ID", 100);
            listViewActivities.Columns.Add("Capacity Varchar", 160);
            listViewActivities.Columns.Add("Lecturer_ID", 160);
            listViewActivities.Columns.Add("Student_ID", 160);


            foreach (Activity activity in activities)
            {
                ListViewItem lvi = new ListViewItem(activity.Schedule_ID.ToString());
                lvi.Tag = activity; // link lecturer object to listview item
                lvi.SubItems.Add(activity.Capacity.ToString());
                lvi.SubItems.Add(activity.Lecturer_ID.ToString());
                lvi.SubItems.Add(activity.Student_ID.ToString());


                listViewActivities.Items.Add(lvi);
            }
        }
    }
}
