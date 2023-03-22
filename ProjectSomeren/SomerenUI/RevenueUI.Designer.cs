namespace SomerenUI
{
    partial class RevenueUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlRevenue = new System.Windows.Forms.Panel();
            pictureBoxRevenue = new System.Windows.Forms.PictureBox();
            listViewRevenue = new System.Windows.Forms.ListView();
            lblRevenue = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRevenue).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { applicationToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1124, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, closeToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(pictureBoxRevenue);
            pnlRevenue.Controls.Add(listViewRevenue);
            pnlRevenue.Controls.Add(lblRevenue);
            pnlRevenue.Location = new System.Drawing.Point(12, 44);
            pnlRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(1086, 545);
            pnlRevenue.TabIndex = 9;
            // 
            // pictureBoxRevenue
            // 
            pictureBoxRevenue.Image = (System.Drawing.Image)resources.GetObject("pictureBoxRevenue.Image");
            pictureBoxRevenue.Location = new System.Drawing.Point(934, 4);
            pictureBoxRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxRevenue.Name = "pictureBoxRevenue";
            pictureBoxRevenue.Size = new System.Drawing.Size(149, 164);
            pictureBoxRevenue.TabIndex = 2;
            pictureBoxRevenue.TabStop = false;
            // 
            // listViewRevenue
            // 
            listViewRevenue.Location = new System.Drawing.Point(18, 56);
            listViewRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewRevenue.MultiSelect = false;
            listViewRevenue.Name = "listViewRevenue";
            listViewRevenue.Size = new System.Drawing.Size(896, 408);
            listViewRevenue.TabIndex = 1;
            listViewRevenue.UseCompatibleStateImageBehavior = false;
            listViewRevenue.View = System.Windows.Forms.View.Details;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRevenue.Location = new System.Drawing.Point(15, 9);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new System.Drawing.Size(131, 41);
            lblRevenue.TabIndex = 0;
            lblRevenue.Text = "Revenue";
            // 
            // RevenueUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1124, 614);
            Controls.Add(pnlRevenue);
            Controls.Add(menuStrip1);
            Name = "RevenueUI";
            Text = "RevenueUI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.PictureBox pictureBoxRevenue;
        private System.Windows.Forms.ListView listViewRevenue;
        private System.Windows.Forms.Label lblRevenue;
    }
}