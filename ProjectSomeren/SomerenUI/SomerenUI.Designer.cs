namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.pnlActivities = new System.Windows.Forms.Panel();
            this.pictureBoxActivities = new System.Windows.Forms.PictureBox();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.lblActivities = new System.Windows.Forms.Label();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.pictureBoxRooms = new System.Windows.Forms.PictureBox();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.lblRooms = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            this.pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivities)).BeginInit();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click_1);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(14, 36);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(15, 17);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(262, 20);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.pictureBoxStudents);
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.lblStudents);
            this.pnlStudents.Location = new System.Drawing.Point(11, 39);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1072, 621);
            this.pnlStudents.TabIndex = 2;
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudents.Image")));
            this.pictureBoxStudents.Location = new System.Drawing.Point(920, 0);
            this.pictureBoxStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(149, 164);
            this.pictureBoxStudents.TabIndex = 2;
            this.pictureBoxStudents.TabStop = false;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(18, 56);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(875, 408);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudents.Location = new System.Drawing.Point(15, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(134, 41);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students";
            // 
            // pnlActivities
            // 
            this.pnlActivities.Controls.Add(this.pictureBoxActivities);
            this.pnlActivities.Controls.Add(this.listViewActivities);
            this.pnlActivities.Controls.Add(this.lblActivities);
            this.pnlActivities.Location = new System.Drawing.Point(8, 51);
            this.pnlActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlActivities.Name = "pnlActivities";
            this.pnlActivities.Size = new System.Drawing.Size(1072, 621);
            this.pnlActivities.TabIndex = 4;
            // 
            // pictureBoxActivities
            // 
            this.pictureBoxActivities.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxActivities.Image")));
            this.pictureBoxActivities.Location = new System.Drawing.Point(920, 0);
            this.pictureBoxActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxActivities.Name = "pictureBoxActivities";
            this.pictureBoxActivities.Size = new System.Drawing.Size(149, 164);
            this.pictureBoxActivities.TabIndex = 2;
            this.pictureBoxActivities.TabStop = false;
            // 
            // listViewActivities
            // 
            this.listViewActivities.Location = new System.Drawing.Point(18, 56);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(875, 408);
            this.listViewActivities.TabIndex = 1;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivities.Location = new System.Drawing.Point(15, 9);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(135, 41);
            this.lblActivities.TabIndex = 0;
            this.lblActivities.Text = "Activities";
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.pictureBoxRooms);
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Controls.Add(this.lblRooms);
            this.pnlRooms.Location = new System.Drawing.Point(5, 60);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1072, 621);
            this.pnlRooms.TabIndex = 5;
            // 
            // pictureBoxRooms
            // 
            this.pictureBoxRooms.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRooms.Image")));
            this.pictureBoxRooms.Location = new System.Drawing.Point(920, 0);
            this.pictureBoxRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRooms.Name = "pictureBoxRooms";
            this.pictureBoxRooms.Size = new System.Drawing.Size(149, 164);
            this.pictureBoxRooms.TabIndex = 2;
            this.pictureBoxRooms.TabStop = false;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Location = new System.Drawing.Point(18, 56);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(875, 408);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRooms.Location = new System.Drawing.Point(15, 9);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(110, 41);
            this.lblRooms.TabIndex = 0;
            this.lblRooms.Text = "Rooms";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 673);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlActivities);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            this.pnlActivities.ResumeLayout(false);
            this.pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivities)).EndInit();
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBoxRooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.PictureBox pictureBoxActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label lblActivities;
    }
}