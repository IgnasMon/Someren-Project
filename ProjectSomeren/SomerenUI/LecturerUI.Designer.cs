namespace SomerenUI
{
    partial class LecturerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLecturers = new System.Windows.Forms.Panel();
            this.pictureBoxLecturers = new System.Windows.Forms.PictureBox();
            this.listViewLecturers = new System.Windows.Forms.ListView();
            this.lblLecturers = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // pnlLecturers
            // 
            this.pnlLecturers.Controls.Add(this.pictureBoxLecturers);
            this.pnlLecturers.Controls.Add(this.listViewLecturers);
            this.pnlLecturers.Controls.Add(this.lblLecturers);
            this.pnlLecturers.Location = new System.Drawing.Point(12, 44);
            this.pnlLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLecturers.Name = "pnlLecturers";
            this.pnlLecturers.Size = new System.Drawing.Size(1086, 545);
            this.pnlLecturers.TabIndex = 8;
            // 
            // pictureBoxLecturers
            // 
            this.pictureBoxLecturers.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLecturers.Image")));
            this.pictureBoxLecturers.Location = new System.Drawing.Point(934, 4);
            this.pictureBoxLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLecturers.Name = "pictureBoxLecturers";
            this.pictureBoxLecturers.Size = new System.Drawing.Size(149, 164);
            this.pictureBoxLecturers.TabIndex = 2;
            this.pictureBoxLecturers.TabStop = false;
            // 
            // listViewLecturers
            // 
            this.listViewLecturers.Location = new System.Drawing.Point(18, 56);
            this.listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewLecturers.MultiSelect = false;
            this.listViewLecturers.Name = "listViewLecturers";
            this.listViewLecturers.Size = new System.Drawing.Size(896, 408);
            this.listViewLecturers.TabIndex = 1;
            this.listViewLecturers.UseCompatibleStateImageBehavior = false;
            this.listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // lblLecturers
            // 
            this.lblLecturers.AutoSize = true;
            this.lblLecturers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLecturers.Location = new System.Drawing.Point(15, 9);
            this.lblLecturers.Name = "lblLecturers";
            this.lblLecturers.Size = new System.Drawing.Size(138, 41);
            this.lblLecturers.TabIndex = 0;
            this.lblLecturers.Text = "Lecturers";
            // 
            // LecturerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 685);
            this.Controls.Add(this.pnlLecturers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LecturerUI";
            this.Text = "LecturerUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlLecturers.ResumeLayout(false);
            this.pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

    // Lecturer Panel
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.PictureBox pictureBoxLecturers;
        private System.Windows.Forms.Label lblLecturers;
        // Lecturer ListViewItem
        private System.Windows.Forms.ListView listViewLecturers;
    }
}