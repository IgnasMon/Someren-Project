namespace SomerenUI
{
    partial class ActivityParticipantUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityParticipantUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelActivityID = new System.Windows.Forms.Label();
            this.buttonRemoveParticipant = new System.Windows.Forms.Button();
            this.buttonAddParticipant = new System.Windows.Forms.Button();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxActivityID = new System.Windows.Forms.TextBox();
            this.listViewActivityParticipants = new System.Windows.Forms.ListView();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1162, 30);
            this.menuStrip1.TabIndex = 5;
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.labelStudentID);
            this.pnlStudents.Controls.Add(this.labelActivityID);
            this.pnlStudents.Controls.Add(this.buttonRemoveParticipant);
            this.pnlStudents.Controls.Add(this.buttonAddParticipant);
            this.pnlStudents.Controls.Add(this.textBoxStudentID);
            this.pnlStudents.Controls.Add(this.textBoxActivityID);
            this.pnlStudents.Controls.Add(this.listViewActivityParticipants);
            this.pnlStudents.Controls.Add(this.listViewActivities);
            this.pnlStudents.Controls.Add(this.labelParticipants);
            this.pnlStudents.Controls.Add(this.pictureBoxStudents);
            this.pnlStudents.Controls.Add(this.lblStudents);
            this.pnlStudents.Location = new System.Drawing.Point(12, 34);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1140, 480);
            this.pnlStudents.TabIndex = 6;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(910, 322);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(79, 20);
            this.labelStudentID.TabIndex = 12;
            this.labelStudentID.Text = "Student ID";
            // 
            // labelActivityID
            // 
            this.labelActivityID.AutoSize = true;
            this.labelActivityID.Location = new System.Drawing.Point(912, 282);
            this.labelActivityID.Name = "labelActivityID";
            this.labelActivityID.Size = new System.Drawing.Size(77, 20);
            this.labelActivityID.TabIndex = 11;
            this.labelActivityID.Text = "Activity ID";
            // 
            // buttonRemoveParticipant
            // 
            this.buttonRemoveParticipant.Location = new System.Drawing.Point(1022, 396);
            this.buttonRemoveParticipant.Name = "buttonRemoveParticipant";
            this.buttonRemoveParticipant.Size = new System.Drawing.Size(106, 54);
            this.buttonRemoveParticipant.TabIndex = 10;
            this.buttonRemoveParticipant.Text = "Remove Participant";
            this.buttonRemoveParticipant.UseVisualStyleBackColor = true;
            this.buttonRemoveParticipant.Click += new System.EventHandler(this.buttonRemoveParticipant_Click);
            // 
            // buttonAddParticipant
            // 
            this.buttonAddParticipant.Location = new System.Drawing.Point(910, 396);
            this.buttonAddParticipant.Name = "buttonAddParticipant";
            this.buttonAddParticipant.Size = new System.Drawing.Size(106, 54);
            this.buttonAddParticipant.TabIndex = 9;
            this.buttonAddParticipant.Text = "Add Participant";
            this.buttonAddParticipant.UseVisualStyleBackColor = true;
            this.buttonAddParticipant.Click += new System.EventHandler(this.buttonAddParticipant_Click);
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(1003, 315);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(125, 27);
            this.textBoxStudentID.TabIndex = 8;
            // 
            // textBoxActivityID
            // 
            this.textBoxActivityID.Location = new System.Drawing.Point(1003, 275);
            this.textBoxActivityID.Name = "textBoxActivityID";
            this.textBoxActivityID.Size = new System.Drawing.Size(125, 27);
            this.textBoxActivityID.TabIndex = 7;
            // 
            // listViewActivityParticipants
            // 
            this.listViewActivityParticipants.FullRowSelect = true;
            this.listViewActivityParticipants.Location = new System.Drawing.Point(606, 56);
            this.listViewActivityParticipants.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewActivityParticipants.MultiSelect = false;
            this.listViewActivityParticipants.Name = "listViewActivityParticipants";
            this.listViewActivityParticipants.Size = new System.Drawing.Size(288, 408);
            this.listViewActivityParticipants.TabIndex = 6;
            this.listViewActivityParticipants.UseCompatibleStateImageBehavior = false;
            this.listViewActivityParticipants.View = System.Windows.Forms.View.Details;
            this.listViewActivityParticipants.SelectedIndexChanged += new System.EventHandler(this.listViewActivityParticipants_SelectedIndexChanged);
            // 
            // listViewActivities
            // 
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.Location = new System.Drawing.Point(15, 56);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewActivities.MultiSelect = false;
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(538, 408);
            this.listViewActivities.TabIndex = 5;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            this.listViewActivities.SelectedIndexChanged += new System.EventHandler(this.listViewActivities_SelectedIndexChanged);
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParticipants.Location = new System.Drawing.Point(606, 9);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(170, 41);
            this.labelParticipants.TabIndex = 4;
            this.labelParticipants.Text = "Participants";
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudents.Image")));
            this.pictureBoxStudents.Location = new System.Drawing.Point(1007, 0);
            this.pictureBoxStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(130, 119);
            this.pictureBoxStudents.TabIndex = 2;
            this.pictureBoxStudents.TabStop = false;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudents.Location = new System.Drawing.Point(15, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(135, 41);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Activities";
            // 
            // ActivityParticipantUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 514);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ActivityParticipantUI";
            this.Text = "ActivityParticipantUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ListView listViewActivityParticipants;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelActivityID;
        private System.Windows.Forms.Button buttonRemoveParticipant;
        private System.Windows.Forms.Button buttonAddParticipant;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxActivityID;
    }
}