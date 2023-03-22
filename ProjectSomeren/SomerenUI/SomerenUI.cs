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
        }

        private void ShowDashboardPanel()
        {
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

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrinkUI drinkUI = new DrinkUI();
            drinkUI.ShowDialog();
        }
        // Students - END

        // Lecturers - Ignas
        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LecturerUI lecturerUI = new LecturerUI();
            lecturerUI.ShowDialog();
        }
    // Lecturer - END
    // Revenue - Ignas
        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevenueUI RevenueUI = new RevenueUI();
            RevenueUI.ShowDialog();
        }
    // Revenue - END

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
            ActivityUI ActivityUI = new ActivityUI();
            ActivityUI.ShowDialog();   
        }
        // Activity - END

        private void vATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VatUI VATUI = new VatUI();
            VATUI.ShowDialog();
        }

    }
}