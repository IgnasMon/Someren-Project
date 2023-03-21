namespace SomerenUI
{
    partial class ActivityUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityUI));
            this.pnlActivities = new System.Windows.Forms.Panel();
            this.pictureBoxActivities = new System.Windows.Forms.PictureBox();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.lblActivities = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivities)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlActivities
            // 
            this.pnlActivities.Controls.Add(this.pictureBoxActivities);
            this.pnlActivities.Controls.Add(this.listViewActivities);
            this.pnlActivities.Controls.Add(this.lblActivities);
            this.pnlActivities.Location = new System.Drawing.Point(13, 59);
            this.pnlActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActivities.Name = "pnlActivities";
            this.pnlActivities.Size = new System.Drawing.Size(1340, 776);
            this.pnlActivities.TabIndex = 5;
            // 
            // pictureBoxActivities
            // 
            this.pictureBoxActivities.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxActivities.Image")));
            this.pictureBoxActivities.Location = new System.Drawing.Point(1150, 0);
            this.pictureBoxActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxActivities.Name = "pictureBoxActivities";
            this.pictureBoxActivities.Size = new System.Drawing.Size(186, 205);
            this.pictureBoxActivities.TabIndex = 2;
            this.pictureBoxActivities.TabStop = false;
            // 
            // listViewActivities
            // 
            this.listViewActivities.Location = new System.Drawing.Point(22, 70);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(1093, 509);
            this.listViewActivities.TabIndex = 1;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivities.Location = new System.Drawing.Point(19, 11);
            this.lblActivities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(162, 48);
            this.lblActivities.TabIndex = 0;
            this.lblActivities.Text = "Activities";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1470, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // ActivityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 904);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlActivities);
            this.Name = "ActivityUI";
            this.Text = "ActivityUI";
            this.pnlActivities.ResumeLayout(false);
            this.pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivities)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.PictureBox pictureBoxActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}