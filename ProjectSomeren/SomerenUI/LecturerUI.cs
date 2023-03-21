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
    public partial class LecturerUI : Form
    {
        public LecturerUI()
        {
            InitializeComponent();
            ShowLecturersPanel();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Lecturers - Ignas
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel(); 
        }

        private void ShowLecturersPanel()
        {
            try
            {
                // get and display all lecturers
                List<Teacher> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }

        private List<Teacher> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Teacher> lecturers = lecturerService.GetLecturers();
            return lecturers;
        }

        private void DisplayLecturers(List<Teacher> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Clear();

            // Create column names at the top of the ListViewItem
            listViewLecturers.Columns.Add("Lecturer Id", 100);
            listViewLecturers.Columns.Add("First Name", 140);
            listViewLecturers.Columns.Add("Last Name", 140);
            listViewLecturers.Columns.Add("Telephone Number", 160);
            listViewLecturers.Columns.Add("Date of Birth", 150);
            listViewLecturers.Columns.Add("Supervisor", 100);
            listViewLecturers.Columns.Add("Room Id", 100);

            // Fill in the Lecturer table with entries from the DB 
            foreach (Teacher lecturer in lecturers)
            {
                ListViewItem lvi = new ListViewItem(lecturer.Id.ToString());
                lvi.Tag = lecturer;   // link lecturer object to listview item
                lvi.SubItems.Add(lecturer.FirstName.ToString());
                lvi.SubItems.Add(lecturer.LastName.ToString());
                lvi.SubItems.Add(lecturer.TelephoneNumber.ToString());
                lvi.SubItems.Add(lecturer.DateOfBirth.ToString());
                lvi.SubItems.Add(lecturer.IsSupervisor.ToString());
                lvi.SubItems.Add(lecturer.RoomID.ToString());
                listViewLecturers.Items.Add(lvi);
            }
        }
        // Lecturer - END
    }
}
