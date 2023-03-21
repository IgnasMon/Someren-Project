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
            pnlRooms.Visible = false;
            pnlStudents.Visible = false;
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

    // Students - Zoran
        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            listViewStudents.Columns.Add("Student Id", 100);
            listViewStudents.Columns.Add("Class", 60);
            listViewStudents.Columns.Add("First Name", 120);
            listViewStudents.Columns.Add("Last Name", 120);
            listViewStudents.Columns.Add("Telephone Number", 160);
            listViewStudents.Columns.Add("Room Id", 100);
            
            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.StudentID.ToString());
                li.Tag = student;   // link student object to listview item
                li.SubItems.Add(student.Class.ToString());
                li.SubItems.Add(student.FirstName.ToString());
                li.SubItems.Add(student.LastName.ToString());
                li.SubItems.Add(student.TelephoneNumber.ToString());
                li.SubItems.Add(student.RoomID.ToString());
                listViewStudents.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
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
            ShowRoomsPanel();
        }

        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();

            // show lecturers
            pnlRooms.Show();

            try
            {
                // get and display all lecturers
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Clear();

            listViewRooms.Columns.Add("Room Id", 100);
            listViewRooms.Columns.Add("Capacity", 160);
            listViewRooms.Columns.Add("Floor", 160);
            listViewRooms.Columns.Add("Building", 160);
            

            foreach (Room room in rooms)
            {
                ListViewItem rvi = new ListViewItem(room.Id.ToString());
                rvi.Tag = room;   // link lecturer object to listview item
                rvi.SubItems.Add(room.capacity.ToString());
                rvi.SubItems.Add(room.floor.ToString());
                rvi.SubItems.Add(room.building.ToString());
                listViewRooms.Items.Add(rvi);
            }
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
            pnlRooms.Hide();

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