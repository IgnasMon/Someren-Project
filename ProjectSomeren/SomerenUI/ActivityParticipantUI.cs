using SomerenDAL;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SomerenUI
{
    public partial class ActivityParticipantUI : Form
    {
        public ActivityParticipantUI()
        {
            InitializeComponent();
            LoadActivities();
            LoadActivityParticipants();
            RefreshActivitiesPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshActivitiesPanel();
            RefreshActivityParticipantsPanel();
            listViewActivityParticipants.Items.Clear();
        }

        #region Activities

        private void RefreshActivitiesPanel()
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

        private void LoadActivities()
        {
            // Full clear of ListView
            listViewActivities.Clear();

            // Create column names at the top of the ListViewItem
            listViewActivities.Columns.Add("ID", 60);                   
            listViewActivities.Columns.Add("Description", 150);         
            listViewActivities.Columns.Add("Start Date Time", 150);     
            listViewActivities.Columns.Add("End Date Time", 150);       
        }

        private void DisplayActivities(List<Activity> activities)
        {
            // Clear the listview items before filling it
            listViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem lvi = new ListViewItem(activity.Activity_ID.ToString());
                lvi.Tag = activity; // link activity object to listview item
                lvi.SubItems.Add(activity.Description.ToString());
                lvi.SubItems.Add(activity.StartDateTime.ToString());
                lvi.SubItems.Add(activity.EndDateTime.ToString());

                listViewActivities.Items.Add(lvi);
            }
        }

        // When listViewActivities gets selected show Participants
        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                RefreshActivityParticipantsPanel();
            }
        }

        #endregion
        #region Activity Participants

        private void RefreshActivityParticipantsPanel()
        {
            try
            {
                // get and display all activity participants
                List<ActivityParticipant> activityParticipants = GetActivityParticipants();
                DisplayActivityParticipants(activityParticipants);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activity participants: " + e.Message);
            }
        }

        private List<ActivityParticipant> GetActivityParticipants()
        {
            ActivityParticipantService activityParticipantsService = new ActivityParticipantService();
            List<ActivityParticipant> activityParticipant = activityParticipantsService.GetActivityParticipants();
            return activityParticipant;
        }

        private void LoadActivityParticipants()
        {
            // Full clear of ListView
            listViewActivityParticipants.Clear();

            // Create column names at the top of the ListViewItem
            listViewActivityParticipants.Columns.Add("Activity ID", 150);
            listViewActivityParticipants.Columns.Add("Student ID", 150);
        }

        private void DisplayActivityParticipants(List<ActivityParticipant> activityParticipants)
        {
            // Clear the listview items before filling it
            listViewActivityParticipants.Items.Clear();

            foreach (ActivityParticipant activityParticipant in activityParticipants)
            {
                ListViewItem lvi = new ListViewItem(activityParticipant.Activity_ID.ToString());
                lvi.Tag = activityParticipant; // link activity object to listview item
                lvi.SubItems.Add(activityParticipant.Student_ID.ToString());

                listViewActivityParticipants.Items.Add(lvi);
            }
        }

        private void listViewActivityParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityParticipant selectedActivity = (ActivityParticipant)listViewActivityParticipants.SelectedItems[0].Tag;

            textBoxActivityID.Text = selectedActivity.Activity_ID.ToString();
            textBoxStudentID.Text = selectedActivity.Student_ID.ToString();
        }

        private void buttonAddParticipant_Click(object sender, EventArgs e)
        {
            ActivityParticipantDao activityParticipantDao = new ActivityParticipantDao();

            string activity_ID = textBoxActivityID.Text;
            string student_ID = textBoxStudentID.Text;

            try
            {
                activityParticipantDao.AddActivityParticipant($"INSERT INTO dbo.activityParticipants(activity_ID, student_ID) " +
                                    $"Values({activity_ID}, {student_ID})");
            }
            catch 
            {
                throw new Exception($"Impossible to make students participants if they were already participants for that activity.");
            }

            RefreshActivityParticipantsPanel();
        }

        private void buttonRemoveParticipant_Click(object sender, EventArgs e)
        {
            DialogResult alertResult = MessageBox.Show($"Are you sure that you wish to remove this participant?", "REMOVE PARTICIPANT ALERT!", buttons: MessageBoxButtons.YesNo);
            if (alertResult == DialogResult.Yes)
            {
                DeleteParticipant();
            }
            else if (alertResult == DialogResult.No)
            {
                MessageBox.Show("Action was cancelled!");
            }
        }

        private void DeleteParticipant()
        {
            ActivityParticipantDao activityParticipantDao = new ActivityParticipantDao();

            string activity_ID = textBoxActivityID.Text;
            string student_ID = textBoxStudentID.Text;

            activityParticipantDao.RemoveActivityParticipant($"DELETE FROM dbo.activityParticipants " +
                $"WHERE " +
                $"activity_ID = {activity_ID} AND " +
                $"student_ID = {student_ID}");

            RefreshActivityParticipantsPanel();
        }
        #endregion
    }
}
