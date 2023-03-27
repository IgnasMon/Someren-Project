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

        #region Zoran
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

        private void activityParticipantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityParticipantUI activityParticipantsUI = new ActivityParticipantUI();
            activityParticipantsUI.ShowDialog();
        }
        #endregion Zoran

        #region Ignas
        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LecturerUI lecturerUI = new LecturerUI();
            lecturerUI.ShowDialog();
        }
        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevenueUI RevenueUI = new RevenueUI();
            RevenueUI.ShowDialog();
        }
        #endregion Ignas

        #region Saif
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsUI roomsUI = new RoomsUI(); 
            roomsUI.ShowDialog();
        }

        private void vATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VatUI VATUI = new VatUI();
            VATUI.ShowDialog();
        }
        #endregion Saif

        #region Sagy
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)   
        {
            ActivityUI ActivityUI = new ActivityUI();
            ActivityUI.ShowDialog();   
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashRegisterUI cashRegisterUI = new CashRegisterUI();
            cashRegisterUI.ShowDialog();
        }

        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivitySupervisorUI ActivitySupervisorUI = new ActivitySupervisorUI();
            ActivitySupervisorUI.ShowDialog();
        }
        #endregion Sagy
    }
}