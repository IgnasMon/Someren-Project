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
    public partial class ActivitySupervisorUI : Form
    {
        public ActivitySupervisorUI()
        {
            InitializeComponent();
        }

        private void ActivitySupervisorUI_Load(object sender, EventArgs e)
        {
            void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                 ActivityUI activity = new ActivityUI();
                activity.ShowDialog();
            }

            void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
            {
                CashRegisterUI cashRegisterUI = new CashRegisterUI();
                cashRegisterUI.ShowDialog();
            }
        
             void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ActivitySupervisorUI ActivitySupervisorUI = new ActivitySupervisorUI();
                ActivitySupervisorUI.ShowDialog();
            }
            }
            
    }
}
