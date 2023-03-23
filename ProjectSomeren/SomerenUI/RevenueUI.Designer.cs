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
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlOrder = new System.Windows.Forms.Panel();
            pictureBoxOrder = new System.Windows.Forms.PictureBox();
            listViewOrder = new System.Windows.Forms.ListView();
            lblOrder = new System.Windows.Forms.Label();
            pnlRevenue = new System.Windows.Forms.Panel();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            listViewSales = new System.Windows.Forms.ListView();
            lblSales = new System.Windows.Forms.Label();
            pictureBoxRevenue = new System.Windows.Forms.PictureBox();
            listViewCustomers = new System.Windows.Forms.ListView();
            lblRevenue = new System.Windows.Forms.Label();
            lblCustomers = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrder).BeginInit();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRevenue).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { applicationToolStripMenuItem, ordersToolStripMenuItem, revenueToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1277, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, refreshToolStripMenuItem, closeToolStripMenuItem });
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
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // pnlOrder
            // 
            pnlOrder.Controls.Add(pictureBoxOrder);
            pnlOrder.Controls.Add(listViewOrder);
            pnlOrder.Controls.Add(lblOrder);
            pnlOrder.Location = new System.Drawing.Point(12, 44);
            pnlOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new System.Drawing.Size(1086, 545);
            pnlOrder.TabIndex = 9;
            // 
            // pictureBoxOrder
            // 
            pictureBoxOrder.Image = (System.Drawing.Image)resources.GetObject("pictureBoxOrder.Image");
            pictureBoxOrder.Location = new System.Drawing.Point(934, 4);
            pictureBoxOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxOrder.Name = "pictureBoxOrder";
            pictureBoxOrder.Size = new System.Drawing.Size(149, 164);
            pictureBoxOrder.TabIndex = 2;
            pictureBoxOrder.TabStop = false;
            // 
            // listViewOrder
            // 
            listViewOrder.Location = new System.Drawing.Point(18, 56);
            listViewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewOrder.MultiSelect = false;
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new System.Drawing.Size(896, 408);
            listViewOrder.TabIndex = 1;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOrder.Location = new System.Drawing.Point(15, 9);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new System.Drawing.Size(95, 41);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "Order";
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(lblCustomers);
            pnlRevenue.Controls.Add(monthCalendar1);
            pnlRevenue.Controls.Add(listViewSales);
            pnlRevenue.Controls.Add(lblSales);
            pnlRevenue.Controls.Add(pictureBoxRevenue);
            pnlRevenue.Controls.Add(listViewCustomers);
            pnlRevenue.Controls.Add(lblRevenue);
            pnlRevenue.Location = new System.Drawing.Point(9, 40);
            pnlRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(1177, 545);
            pnlRevenue.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new System.Drawing.Point(18, 65);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // listViewSales
            // 
            listViewSales.Location = new System.Drawing.Point(292, 95);
            listViewSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewSales.MultiSelect = false;
            listViewSales.Name = "listViewSales";
            listViewSales.Size = new System.Drawing.Size(228, 373);
            listViewSales.TabIndex = 4;
            listViewSales.UseCompatibleStateImageBehavior = false;
            listViewSales.View = System.Windows.Forms.View.Details;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSales.Location = new System.Drawing.Point(292, 50);
            lblSales.Name = "lblSales";
            lblSales.Size = new System.Drawing.Size(85, 41);
            lblSales.TabIndex = 3;
            lblSales.Text = "Sales";
            // 
            // pictureBoxRevenue
            // 
            pictureBoxRevenue.Image = (System.Drawing.Image)resources.GetObject("pictureBoxRevenue.Image");
            pictureBoxRevenue.Location = new System.Drawing.Point(1025, 4);
            pictureBoxRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxRevenue.Name = "pictureBoxRevenue";
            pictureBoxRevenue.Size = new System.Drawing.Size(149, 164);
            pictureBoxRevenue.TabIndex = 2;
            pictureBoxRevenue.TabStop = false;
            // 
            // listViewCustomers
            // 
            listViewCustomers.Location = new System.Drawing.Point(526, 95);
            listViewCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewCustomers.MultiSelect = false;
            listViewCustomers.Name = "listViewCustomers";
            listViewCustomers.Size = new System.Drawing.Size(289, 373);
            listViewCustomers.TabIndex = 1;
            listViewCustomers.UseCompatibleStateImageBehavior = false;
            listViewCustomers.View = System.Windows.Forms.View.Details;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRevenue.Location = new System.Drawing.Point(21, 15);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new System.Drawing.Size(221, 41);
            lblRevenue.TabIndex = 0;
            lblRevenue.Text = "Revenue report";
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCustomers.Location = new System.Drawing.Point(526, 50);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new System.Drawing.Size(160, 41);
            lblCustomers.TabIndex = 6;
            lblCustomers.Text = "Customers";
            // 
            // RevenueUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1277, 614);
            Controls.Add(pnlRevenue);
            Controls.Add(pnlOrder);
            Controls.Add(menuStrip1);
            Name = "RevenueUI";
            Text = "RevenueUI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrder).EndInit();
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
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.PictureBox pictureBoxOrder;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.ListView listViewCustomers;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ListView listViewSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.PictureBox pictureBoxRevenue;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblCustomers;
    }
}