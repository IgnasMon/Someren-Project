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
            pnlDashboard.Visible = false;
            pnlLecturers.Visible = false;
            pnlRooms.Visible = false;
            pnlStudents.Visible = false;
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlLecturers.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();

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

    // for Lecturers - Ignas
        private void ShowLecturersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();

            // show lecturers
            pnlLecturers.Visible = true;
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

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name);
                li.Tag = student;   // link student object to listview item
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
    // for Lecturers - Ignas
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        // for Lecturers - Ignas
        /*private List<Teacher> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Teacher> lecturers = lecturerService.GetLecturer();
            return lecturers;
        }*/

        /*private void DisplayLecturers(List<Teacher> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Clear();

            foreach (Teacher lecturer in lecturers)
            {
                ListViewItem li = new ListViewItem(lecturer.Id.ToString());
                li.Tag = lecturer;   // link lecturer object to listview item
                listViewLecturers.Items.Add(li);
                li.SubItems.Add(lecturer.FirstName);
                li.SubItems.Add(lecturer.LastName);
                li.SubItems.Add(lecturer.TelephoneNumber);
                li.SubItems.Add(lecturer.DateOfBirth.ToString());
            }
        }*/
    }
}