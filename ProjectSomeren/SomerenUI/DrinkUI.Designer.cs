namespace SomerenUI
{
    partial class DrinkUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.pictureBoxDrinks = new System.Windows.Forms.PictureBox();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1089, 28);
            this.menuStrip1.TabIndex = 8;
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
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click_1);
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.pictureBoxDrinks);
            this.pnlDrinks.Controls.Add(this.listViewDrinks);
            this.pnlDrinks.Controls.Add(this.lblDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(12, 32);
            this.pnlDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(1086, 545);
            this.pnlDrinks.TabIndex = 9;
            // 
            // pictureBoxDrinks
            // 
            this.pictureBoxDrinks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDrinks.Image")));
            this.pictureBoxDrinks.Location = new System.Drawing.Point(934, 4);
            this.pictureBoxDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxDrinks.Name = "pictureBoxDrinks";
            this.pictureBoxDrinks.Size = new System.Drawing.Size(149, 164);
            this.pictureBoxDrinks.TabIndex = 2;
            this.pictureBoxDrinks.TabStop = false;
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.Location = new System.Drawing.Point(18, 56);
            this.listViewDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewDrinks.MultiSelect = false;
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(896, 408);
            this.listViewDrinks.TabIndex = 1;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDrinks.Location = new System.Drawing.Point(15, 9);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(101, 41);
            this.lblDrinks.TabIndex = 0;
            this.lblDrinks.Text = "Drinks";
            // 
            // DrinkUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 507);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DrinkUI";
            this.Text = "DrinkUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.PictureBox pictureBoxDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label lblDrinks;
    }
}