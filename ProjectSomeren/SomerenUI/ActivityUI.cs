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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class ActivityUI : Form
    {
        const int IndentifierCreate = 1, IndentifierUpdate = 2, IndentifierRemove = 3;

        
        // Activity - Sagy
        public ActivityUI()
        {
            InitializeComponent();
            LoadActivities();         // Ignas Assignment 4 - Added a call method for Loading the Columns of ListView
            RefreshActivitiesPanel();
        }

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

        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            listViewActivities.Items.Clear(); // Ignas Assignment 4 - changed so it only clears Items not everything

            //Ignas Assignement 4 - Created a method for loading top part of the ListView which is called from ShowActivitiesPanel

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
        // Activity - End

        // ActivityCRUD - Ignas - Assignment 4 
        //Load the listView with all column names that will be present
        private void LoadActivities()
        {
            // Full clear of ListView
            listViewActivities.Clear();

            // Ignas Assignment 4 - Changed a few settings
            // Create column names at the top of the ListViewItem
            listViewActivities.Columns.Add("ID", 60);                   // Column name "Activity ID" -> "ID" and Size 100 -> 60
            listViewActivities.Columns.Add("Description", 150);         // Size 160 -> 150
            listViewActivities.Columns.Add("Start Date Time", 150);     // Size 160 -> 150
            listViewActivities.Columns.Add("End Date Time", 150);       // Size 160 -> 150
        }

        // Made the refresh button functional
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewActivities.Items.Clear();
            RefreshActivitiesPanel();
        }

        // Created a button for Creating a new Activity
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AlertBox(IndentifierCreate, "Create a new activity?", "CREATE ALERT!");
        }

        // Created a button for Updating/Altering a selected and existing Activity
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AlertBox(IndentifierUpdate, "Update selected activity?", "UPDATE ALERT!");
        }

        // Created a button for Deleting Activity
        private void btnDelete_Click(object sender, EventArgs e)
        {
            AlertBox(IndentifierRemove, "DELETE selected activity?", "DELETE ALERT!");
        }


        private void AddNewActivity()
        {
            ActivityService activityService = new ActivityService();
            try
            {
                activityService.AddNewActivity(GetActivityCRUD(IndentifierCreate));
            } catch (Exception ex)
            {
                throw new Exception($"Problem when creating {ex}");
            }
        }

        private void UpdateActivity()
        {
            ActivityService activityService = new ActivityService();
            try
            {
                activityService.UpdateActivity(GetActivityCRUD(IndentifierUpdate));
            }
            catch (Exception ex)
            {
                throw new Exception($"Problem when updating {ex}");
            }
        }

        private void RemoveActivity()
        {
            ActivityService activityService = new ActivityService();
            try
            {
                activityService.RemoveActivity(GetActivityCRUD(IndentifierRemove));
            }
            catch (Exception ex)
            {
                throw new Exception($"Problem when deleting {ex}");
            }
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if there is no activity selected, then return...
            ClearCRUDPanel();
            if (listViewActivities.SelectedItems.Count <= 0)
                return;

            Activity selectedActivity = (Activity)listViewActivities.SelectedItems[0].Tag;

            textBoxActivityCRUDID.Text = selectedActivity.Activity_ID.ToString();
            textBoxActivityCRUDDesc.Text = selectedActivity.Description;
            dateTimePickerStart.Text = selectedActivity.StartDateTime.ToString();
            dateTimePickerEnd.Text = selectedActivity.EndDateTime.ToString();
        }

        private Activity GetActivityCRUD(int indentifier)
        {
            Activity activity = new Activity();

            try
            {
                if(indentifier != IndentifierCreate)
                    activity.Activity_ID = int.Parse(textBoxActivityCRUDID.Text);

                activity.Description = textBoxActivityCRUDDesc.Text;
                activity.StartDateTime = DateTime.Parse(dateTimePickerStart.Text);
                activity.EndDateTime = DateTime.Parse(dateTimePickerEnd.Text);
            }
            catch (Exception ex)
            {
                throw new Exception($"Problem while converting CRUD data to Model item:\n", ex);
            }

            return activity;
        }

        private void ClearCRUDPanel()
        {
            textBoxActivityCRUDID.Text = "";
            textBoxActivityCRUDDesc.Text = "";
            dateTimePickerStart.Text = DateTime.Now.ToString();
            dateTimePickerEnd.Text = DateTime.Now.ToString();
        }

        private void AlertBox(int indentifier, string text, string caption)
        {
            DialogResult alertResult = MessageBox.Show($"Are you sure you want to {text}", caption, buttons: MessageBoxButtons.YesNo);
            if (alertResult == DialogResult.Yes)
            {
                try
                {
                    if(indentifier == IndentifierCreate)
                        AddNewActivity();
                    if (indentifier == IndentifierUpdate)
                        UpdateActivity();
                    if (indentifier == IndentifierRemove)
                        RemoveActivity();

                    RefreshActivitiesPanel();
                    ClearCRUDPanel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (alertResult == DialogResult.No)
                MessageBox.Show("Action was cancelled!");
        }
        // ActivityCRUD - END
    }
}