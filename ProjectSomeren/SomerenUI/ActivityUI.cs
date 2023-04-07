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

            //Ignas Assignment 4 - Created a method for loading top part called Load Activities

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

        #region ActivityCRUD-Ignas-Assignment_4 

        #region LoadTable
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
        #endregion

        #region Buttons

        #region Refresh
            // Refresh button refreshes the Table information
            private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listViewActivities.Items.Clear();
                RefreshActivitiesPanel();
            }
        #endregion

        #region ClearFields
            //Clears All edited CRUD fields
            private void btnClearCRUD_Click(object sender, EventArgs e)
            {
                ClearCRUDPanel();
            }
        #endregion

        #region Create
            // Create button for Creating/Adding a new Activity
            private void btnCreate_Click(object sender, EventArgs e)
            {
                AlertBox(IndentifierCreate, "Create a new activity?", "CREATE ALERT!");
            }
        #endregion

        #region Update
            // Update button for Updating/Altering a selected and existing Activity
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                AlertBox(IndentifierUpdate, "Update selected activity?", "UPDATE ALERT!");
            }
        #endregion

        #region Delete
            // Delete button for deleting already existing Activity
            private void btnDelete_Click(object sender, EventArgs e)
            {
                AlertBox(IndentifierRemove, "DELETE selected activity?", "DELETE ALERT!");
            }
        #endregion

        #endregion

        #region Method_SelectActivity
        //Method Selecting Activity
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
        #endregion

        #region Method_GetActivityCRUD
        // Takes the information from textBoxes and dateTimePickers and creates an Activity out of it, using Activity Model
        private Activity GetActivityCRUD(int indentifier)
        {
            Activity activity = new Activity();

            try
            {
                if (indentifier != IndentifierCreate)
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
        #endregion

        #region Method_ClearCRUDPanel
        //Method ClearCRUDPanel
        // clears ActivityCRUDPanel
        private void ClearCRUDPanel()
        {
            textBoxActivityCRUDID.Text = "";
            textBoxActivityCRUDDesc.Text = "";
            dateTimePickerStart.Text = DateTime.Now.ToString();
            dateTimePickerEnd.Text = DateTime.Now.ToString();
        }
        #endregion

        #region AlertBox
        // AlertBox is for confirming or denying the Creation/Update/Removal of Activity
        private void AlertBox(int indentifier, string text, string caption)
        {
            DialogResult alertResult = MessageBox.Show($"Are you sure you want to {text}", caption, buttons: MessageBoxButtons.YesNo);
            if (alertResult == DialogResult.Yes)
            {
                try
                {
                    if (textBoxActivityCRUDID.Text == "")
                    {
                        if (indentifier == IndentifierCreate)
                            if (ValidationCreate())
                            {
                                AddNewActivity();
                                MessageBox.Show("Success!", caption);
                            }
                            else
                            {
                                MessageBox.Show("Action cancelled! Possible problems: \n 1. An activity was selected \n 2. Start Date is later than End Date \n 3. Or the activity at the exact time already exists", caption);
                                return;
                            }
                        if (indentifier == IndentifierUpdate || indentifier == IndentifierRemove)
                            MessageBox.Show("Action cancelled! Possible problems: \n 1. Activity was not selected", caption);
                    }
                    else
                    {
                        if (indentifier == IndentifierUpdate)
                            if (ValidationUpdate(GetActivityCRUD(IndentifierUpdate),
                                                    (Activity)listViewActivities.SelectedItems[0].Tag))
                            {
                                UpdateActivity();
                                MessageBox.Show("Success!", caption);
                            }
                            else
                            {
                                MessageBox.Show("Action cancelled! Possible problems: \n 1. Nothing was changed, \n 2. Start Date is later than End Date", caption);
                                return;
                            }

                        if (indentifier == IndentifierRemove)
                            if (ValidationRemove(GetActivityCRUD(IndentifierUpdate),
                                                    (Activity)listViewActivities.SelectedItems[0].Tag))
                            {
                                RemoveActivity();
                                MessageBox.Show("Success!", caption);
                            }
                            else
                            {
                                MessageBox.Show("Action cancelled! Possible problems: \n 1. Activity was not selected", caption);
                                return;
                            }
                    }

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
        #endregion

        #region CRUD

        #region Method_AddNewActivity
        //Method AddActivity
        private void AddNewActivity()
        {
            ActivityService activityService = new ActivityService();
            try
            {
                activityService.AddNewActivity(GetActivityCRUD(IndentifierCreate));
            }
            catch (Exception ex)
            {
                throw new Exception($"Problem when creating {ex}");
            }
        }
        #endregion

        #region Method_UpdateActivity
        //Method UpdateActivity
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
        #endregion

        #region Method_RemoveActivity
        //Method RemoveActivity
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
        #endregion

        #endregion

        #region Validations

        #region ValidationCreate
        //Method ValidationCreate
        private bool ValidationCreate()
        {
            if (DateTime.Parse(dateTimePickerStart.Text) <= DateTime.Parse(dateTimePickerEnd.Text))
                if (!(ActivityExists(GetActivities(), GetActivityCRUD(IndentifierCreate))))
                    return true;

            return false;
        }
        #endregion

        #region ValidationUpdate
        //Method ValidationUpdate
        private bool ValidationUpdate(Activity editedActivity, Activity selectedActivity)
        {
            if ((editedActivity.Activity_ID == selectedActivity.Activity_ID) &&
                (
                    ((int)String.Compare(editedActivity.Description, selectedActivity.Description) == 1) ||
                    (editedActivity.StartDateTime != selectedActivity.StartDateTime) ||
                    (editedActivity.EndDateTime != selectedActivity.EndDateTime)
                ) &&
                (editedActivity.StartDateTime <= editedActivity.EndDateTime)
                )
                return true;

            return false;
        }
        #endregion

        #region ValidationRemove
        //Method ValidationRemove
        private bool ValidationRemove(Activity removeActivity, Activity selectedActivity)
        {
            if (removeActivity.Activity_ID == selectedActivity.Activity_ID)
                return true;

            return false;
        }
        #endregion

        #region Validation_ActivityExists
        //Method ActivityExists
        // Method - for checking if a new activity that is being created already exists in the list
        private bool ActivityExists(List<Activity> activities, Activity newActivity)
        {
            foreach (Activity activity in activities)
            {
                if ((activity.Description == newActivity.Description) &&
                    (activity.StartDateTime == newActivity.StartDateTime) &&
                    (activity.EndDateTime == newActivity.EndDateTime)
                    )
                    return true;
            }
            return false;
        }
        #endregion

        #endregion

        #endregion
    }
}