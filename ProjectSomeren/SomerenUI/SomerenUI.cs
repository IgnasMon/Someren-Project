using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            pnlActivities.Visible = false;
            
            pnlStudents.Visible = false;
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlActivities.Hide();
          

            // show dashboard
            pnlDashboard.Show();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        // Students - Zoran

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentUI studentUI = new StudentUI();
            studentUI.ShowDialog();
        }

    // Students - END

    // Lecturers - Ignas
        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LecturerUI lecturerUI = new LecturerUI();
            lecturerUI.ShowDialog();
        }
    // Lecturer - END*/

    // Rooms - Saif
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsUI roomsUI = new RoomsUI(); 
            roomsUI.ShowDialog();
        }

        
    // Rooms - END

    // Activity - Sagy
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }
        private void ShowActivitiesPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            

            // show activities
            pnlActivities.Show();

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
            listViewActivities.Columns.Add("Lecturer_ID",160);
            listViewActivities.Columns.Add("Student_ID" ,160);
   

            foreach ( Activity activity in activities)
            {
                ListViewItem lvi = new ListViewItem(activity.Schedule_ID.ToString());
                lvi.Tag = activity; // link lecturer object to listview item
                lvi.SubItems.Add(activity.Capacity.ToString());
                lvi.SubItems.Add(activity.Lecturer_ID.ToString());
                lvi.SubItems.Add(activity.Student_ID.ToString());
               
                
                listViewActivities.Items.Add(lvi);
            }
        }
    // Activity - END
    }
}